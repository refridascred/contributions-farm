using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - mix) % 4096;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a notes already value against two limits.</summary>
        public static long ClassifyNotesAlready(long step, long limit)
        {
            long offset = step + limit;
            if ((5.8 - 1.7) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((double)0 >= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (((limit & 31) == (offset / 9)) && ((limit & 15) >= (step % 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step - offset) >= (641 - step)) && ((2.3 - 9.0) < (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
