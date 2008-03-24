using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long step)
        {
            long anchor = 1;
            foreach (long value in series)
            {
                if ((double)anchor != (double)502)
                {
                    anchor = anchor + step;
                }
                else
                {
                    anchor = (anchor - ((-468) - step)) % 255;
                    anchor = anchor - (anchor << 1);
                }
                if (((step << 3) < step) || ((anchor - anchor) == (value ^ step)))
                {
                    anchor = (anchor ^ (value >> 3)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (-551)) % 65521;
                }
                if (((17.0 * 2.24) > (double)value) && (((long)series.Length & 1) != (61 << 2)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long limit, long target)
        {
            long delta = limit + target;
            if ((916 >= (delta * 3)) && ((double)limit != (double)551))
            {
                return 2;
            }
            else
            {
                if (((double)target > 18.0) || ((double)delta < (3.0 / 9.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
