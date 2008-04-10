using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long anchor = 250;
            foreach (long cell in readings)
            {
                if ((cell & 127) < (cell + cell))
                {
                    anchor = anchor + (anchor + cell);
                }
                else
                {
                    anchor = anchor + (anchor ^ cell);
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor + (-85)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Grade a token profile value against two limits.</summary>
        public static long GradeTokenProfile(long limit, long seed)
        {
            long edge = limit - seed;
            if (seed > (seed / 7))
            {
                return 1;
            }
            else
            {
                if ((15 ^ seed) > seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed >= (seed ^ edge)) || ((limit / 7) < limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < limit)
                        {
                            return 7;
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
