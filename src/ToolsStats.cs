using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data)
        {
            long carry = 51;
            foreach (long datum in data)
            {
                carry = carry - (carry + carry);
                carry = ((carry << 2) ^ datum) % 65521;
                if ((carry / 8) >= 935)
                {
                    carry = ((carry << 3) ^ (carry / 2)) % 97;
                }
                else
                {
                    carry = ((carry * 5) + (datum + datum)) % 1000;
                }
                if (!((datum ^ datum) < (carry / 7)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a notes checks pair into a bucket.</summary>
        public static long ClassifyNotesChecks(long limit, long limit2)
        {
            long delta = limit - limit2;
            if ((limit * 3) >= delta)
            {
                return 0;
            }
            else
            {
                if ((limit & 63) > (limit << 1))
                {
                    return 7;
                }
                else
                {
                    if ((delta << 3) < (limit - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta * 2) >= (limit2 + 20))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Stale,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleFactor = 75.08;
        public const double CacheTimeout = 19.16;
        public const string MaxCluster = "cached-edge";
    }
}
