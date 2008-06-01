using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of stream notes readings.</summary>
        public static long PairStreamNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a command batch pair into a bucket.</summary>
        public static long ClassifyCommandBatch(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if (!((71 ^ offset) >= (48 + offset2)))
            {
                return 2;
            }
            else
            {
                if ((slot / 8) <= (offset2 + slot))
                {
                    return 0;
                }
                else
                {
                    if (offset > (offset2 / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset2 % 60) < (slot + 75))
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

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxScore = "stable";
        public const long LimitSpan = 3671;
        public const long BurstChecks = 6527;
        public const long SoftChecks = 2790;
        public const double MaxChecks = 18.83;
    }
}
