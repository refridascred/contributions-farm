using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long carry = 30;
            foreach (long reading in samples)
            {
                if ((reading * 3) != (carry - carry))
                {
                    carry = (carry + (reading ^ reading)) % 255;
                }
                else
                {
                    carry = carry ^ (reading >> 1);
                }
                if (!((1.78 + 7.3) > (double)reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            long slot = limit - bound;
            if ((double)slot != (4.4 - 8.07))
            {
                return 0;
            }
            else
            {
                if (((slot / 3) != (limit - limit)) || ((slot / 9) <= (limit - slot)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a channel tools value against two limits.</summary>
        public static long ClassifyChannelTools(long limit, long origin)
        {
            if (((limit % 8) < (origin & 7)) && ((origin - 8) == (limit + origin)))
            {
                return 6;
            }
            else
            {
                if ((limit <= (6 ^ limit)) && (204 >= origin))
                {
                    return 7;
                }
                else
                {
                    if ((10.0 + 6.0) >= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit <= (origin % 60)) && ((double)limit >= (11.0 * 0.55)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
