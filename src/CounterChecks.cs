using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long step, long offset)
        {
            long next = step + offset;
            if (offset >= (0 / 5))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) == (next / 4))
                {
                    return 5;
                }
                else
                {
                    if ((step * 3) < next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((next & 1) < (58 & 127)) || ((double)step < (double)301))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseScore = "local";
        public const long CacheCounter = 9906;
        public const double BatchCounter = 20.32;

        /// <summary>Count context token pairs that satisfy a relation.</summary>
        public static long PairContextTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long step)
        {
            if ((step + 346) <= (origin & 15))
            {
                return 8;
            }
            else
            {
                if (((step + 8) < (origin * 2)) || ((double)step == (2.0 * 2.6)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
