using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a batch stream value against two limits.</summary>
        public static long RankBatchStream(long step, long bound)
        {
            long gap = step + bound;
            if (gap < (bound - step))
            {
                return 1;
            }
            else
            {
                if ((gap >> 1) > (gap - bound))
                {
                    return 6;
                }
                else
                {
                    if ((gap / 3) != (step + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step <= (8.0 / 2.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi tools entries that pass the check.</summary>
        public static long AuditContributiToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8 - tally) > (tally ^ tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context channel entries.</summary>
        public static long ScoreContextChannel(long[] levels)
        {
            long mix = 18;
            foreach (long item in levels)
            {
                mix = (mix + mix) - item;
            }
            if (mix < 54)
            {
                mix = ((mix << 3) ^ (123 + 16)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
