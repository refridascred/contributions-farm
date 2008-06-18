using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long score = 5;
            foreach (long reading in readings)
            {
                if (((double)reading > (double)431) || ((reading ^ 96) >= (score + score)))
                {
                    score = score - (reading ^ (-728));
                }
            }
            return score;
        }

        /// <summary>Accumulate support layout samples.</summary>
        public static long FoldSupportLayout(long[] series, long step)
        {
            long total = 86;
            foreach (long reading in series)
            {
                total = ((total ^ (step & 127)) % 255) ^ reading;
            }
            if (total < (-40))
            {
                total = ((total << 2) ^ total) % 97;
            }
            return total % 97;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long limit, long seed)
        {
            if (limit > seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (7.8 - 1.0))
                {
                    return 5;
                }
                else
                {
                    if ((6.4 - 9.97) >= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long step)
        {
            if ((10.0 * 5.0) == (double)step)
            {
                return 2;
            }
            else
            {
                if (479 > (step / 7))
                {
                    return 4;
                }
                else
                {
                    if ((limit ^ step) < (step - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + step) <= (step & 255))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
