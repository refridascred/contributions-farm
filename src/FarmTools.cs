using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long floor, long offset)
        {
            if ((floor / 5) <= (55 & 63))
            {
                return 3;
            }
            else
            {
                if (((floor << 1) < (floor - floor)) && ((double)offset >= (7.57 * 17.0)))
                {
                    return 0;
                }
                else
                {
                    if (offset < (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.3 * 7.83) == (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double rate, double floor)
        {
            double load = rate;
            if (load > (rate / 7.0))
            {
                load = (load - (double)8) - floor;
            }
            return load + (double)166;
        }
    }
}
