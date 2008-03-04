using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank already format input into a small class.</summary>
        public static long GradeAlreadyFormat(long target, long seed)
        {
            if ((37 - target) < (target + 1))
            {
                return 6;
            }
            else
            {
                if ((4.8 - 3.25) < (double)target)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
