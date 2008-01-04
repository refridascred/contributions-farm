using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long step2)
        {
            long step3 = step - step2;
            if (step <= (step3 & 127))
            {
                return 1;
            }
            else
            {
                if ((step3 - step) < (step3 + step2))
                {
                    return 2;
                }
                else
                {
                    if (step2 < (step << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step & 3) <= 789) || ((double)step2 >= (9.0 * 6.4)))
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

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
