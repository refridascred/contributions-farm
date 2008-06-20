using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if ((bound < (bound ^ origin)) || ((origin + 51) != (origin & 63)))
            {
                return 4;
            }
            else
            {
                if ((bound - origin) == (bound / 4))
                {
                    return 6;
                }
                else
                {
                    if (!(19.0 < (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((91 <= (bound * 3)) || ((origin ^ origin) <= (origin / 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count >> 2) >= (cell + count)) || ((449 + count) < (count / 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor format samples.</summary>
        public static long CombineEditorFormat(long[] readings)
        {
            long score = 17;
            foreach (long entry in readings)
            {
                score = (score * 2) + (score >> 5);
                score = score - (entry & 7);
            }
            if (score < (-398))
            {
                score = ((score << 2) ^ (score / 6)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long anchor = -611;
            foreach (long entry in samples)
            {
                if ((anchor % 7) < (anchor - entry))
                {
                    anchor = ((anchor * 2) + (anchor + entry)) % 97;
                }
                anchor = ((anchor << 3) ^ (8 - anchor)) % 255;
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally ^ item) >= (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (carry + carry);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
