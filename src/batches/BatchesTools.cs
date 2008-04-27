using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a counter route pair into a bucket.</summary>
        public static long BucketCounterRoute(long limit, long limit2)
        {
            if ((412 << 1) == (limit ^ limit))
            {
                return 5;
            }
            else
            {
                if (((46 - limit2) == (68 / 7)) || ((double)limit2 < (12.0 / 7.0)))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit2 >= 19.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit2 > 18.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Audit editor order readings against a rule.</summary>
        public static long CountEditorOrderGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((((81 ^ datum) <= (datum + 1)) || ((19.0 / 3.0) <= (double)matches)) || ((datum >= (24 / 3)) || ((9.0 * 6.1) < (double)datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
