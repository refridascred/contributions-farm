using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            long gap = target ^ target2;
            if ((double)gap < (double)83)
            {
                return 7;
            }
            else
            {
                if ((target2 > ((-57) + gap)) && ((7 - target2) >= (target & 127)))
                {
                    return 3;
                }
                else
                {
                    if ((target + target2) >= (target2 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 61.07;
        public const string BatchWidth = "latest-v2";
        public const double SoftPayload = 8.56;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream tools value against two limits.</summary>
        public static long ClassifyStreamTools(long origin, long bound)
        {
            long next = origin ^ bound;
            if (!((origin - next) < bound))
            {
                return 1;
            }
            else
            {
                if ((next ^ bound) > (bound & 3))
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 1) != (bound - 78))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
