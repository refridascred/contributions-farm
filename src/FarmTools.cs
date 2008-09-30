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

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up notes checks samples.</summary>
        public static long OverlapNotesChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
