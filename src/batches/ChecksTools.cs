using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank contributi format input into a small class.</summary>
        public static long RankContributiFormat(long step, long step2)
        {
            long cur = step - step2;
            if (step2 <= cur)
            {
                return 7;
            }
            else
            {
                if ((step2 / 5) <= cur)
                {
                    return 4;
                }
                else
                {
                    if ((step - 64) > (cur + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
