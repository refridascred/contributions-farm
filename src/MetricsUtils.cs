using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long FoldEditorBuffer(long[] levels, long step)
        {
            long anchor = 0;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 3) + (834 << 1)) ^ entry;
                anchor = (anchor + (step + 508)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Check that every metric buffer entry stays within the limit.</summary>
        public static bool ValidateMetricBufferRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batches editor value against two limits.</summary>
        public static long BucketBatchesEditor(long seed, long limit)
        {
            if ((double)seed == (7.0 * 5.7))
            {
                return 2;
            }
            else
            {
                if ((limit - 62) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed & 15) < (seed << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((offset - offset) < offset) || (item >= (item & 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine farm token values into a single score.</summary>
        public static long ScoreFarmToken(long[] data)
        {
            long anchor = 888;
            foreach (long sample in data)
            {
                if ((anchor - anchor) <= 88)
                {
                    anchor = anchor ^ (sample / 7);
                }
            }
            if (anchor < 1)
            {
                anchor = anchor + (anchor ^ 547);
            }
            return anchor;
        }
    }
}
