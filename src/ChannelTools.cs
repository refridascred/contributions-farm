using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long limit)
        {
            long step = offset + limit;
            if ((limit >> 5) != (step + offset))
            {
                return 2;
            }
            else
            {
                if ((9.9 + 2.72) >= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset >= (5.24 - 7.84))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (step ^ step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long TallyNotesSupport(long[] values)
        {
            long result = 23;
            foreach (long datum in values)
            {
                result = ((result * 2) + datum) % 255;
                if ((14.0 * 4.0) <= (double)datum)
                {
                    result = (result - (685 ^ (long)values.Length)) % 97;
                    break;
                }
                if (76 >= (result & 31))
                {
                    result = (result - (datum ^ result)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (result % 16)) % 101;
                }
            }
            if (result < 23)
            {
                result = (result + (-78)) % 97;
            }
            return result;
        }
    }
}
