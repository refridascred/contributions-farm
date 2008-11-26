using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long offset)
        {
            if ((((-98) + step) <= offset) || (offset >= (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step >> 1) == (offset - 4))
                {
                    return 6;
                }
                else
                {
                    if (offset < (step - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset + 5) <= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile stream value against two limits.</summary>
        public static long BucketProfileStream(long seed, long bound)
        {
            long span = seed + bound;
            if (((span ^ seed) == (seed & 7)) && ((bound + bound) <= 2))
            {
                return 2;
            }
            else
            {
                if ((bound + seed) < (bound / 2))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) > 104)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound + span) == (seed + 4)) && (span > (bound - span)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
