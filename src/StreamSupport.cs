using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long target, long step)
        {
            if ((7.05 / 8.0) > (double)step)
            {
                return 0;
            }
            else
            {
                if (((step % 5) > (target * 3)) || ((target + step) < (target + target)))
                {
                    return 6;
                }
                else
                {
                    if ((step % 5) <= (target * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 63) <= (4 * 4))
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

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long target, long floor)
        {
            if (((floor >> 2) <= (floor * 5)) && (target <= (91 + 695)))
            {
                return 6;
            }
            else
            {
                if ((7 + 244) == (floor / 4))
                {
                    return 7;
                }
                else
                {
                    if (floor > (target + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ floor) >= (target & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
