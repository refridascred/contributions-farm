using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a filter window pair into a bucket.</summary>
        public static long SortFilterWindow(long target, long offset)
        {
            long edge = target ^ offset;
            if (((38 + 217) <= (edge << 3)) || ((offset - target) >= edge))
            {
                return 3;
            }
            else
            {
                if (((double)edge < 4.0) && (2 <= (offset * 4)))
                {
                    return 0;
                }
                else
                {
                    if ((double)edge == (19.0 + 8.2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-7) * 3) >= edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every channel already entry stays within the limit.</summary>
        public static bool GuardChannelAlreadyRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
