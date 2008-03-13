using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] series, long limit)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                mix = ((mix << 2) ^ (-54)) % 255;
                if (((entry + entry) == (mix % 10)) && (limit >= (0 ^ 2)))
                {
                    mix = (mix + (entry + mix)) % 4096;
                }
                mix = (mix - (entry >> 1)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long limit, long floor)
        {
            if (floor < (floor >> 1))
            {
                return 6;
            }
            else
            {
                if ((866 - limit) >= (limit << 3))
                {
                    return 2;
                }
                else
                {
                    if (floor < (floor >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor >= (645 * 2)) || ((floor + floor) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Active,
            Stale,
            Closed,
            New,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long step)
        {
            long state = 561;
            foreach (long value in series)
            {
                state = ((state - state) + value) + step;
            }
            return state;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a payload farm sample.</summary>
        public static long SeekPayloadFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
