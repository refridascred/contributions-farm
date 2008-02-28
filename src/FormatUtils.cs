using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long SortCounterMetrics(long step, long limit)
        {
            long slot = step ^ limit;
            if ((limit % 8) < slot)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) == (limit >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((slot * 3) >= (slot << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            if ((double)origin >= 3.71)
            {
                return 2;
            }
            else
            {
                if (origin >= 63)
                {
                    return 4;
                }
                else
                {
                    if ((origin <= seed) && ((origin >> 4) != (848 << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (712 < (seed + 622))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark + (22 + floor)) % 1000;
                mark = (mark << 2) ^ ((long)i % 5);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool VerifyCommandSchemaBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
