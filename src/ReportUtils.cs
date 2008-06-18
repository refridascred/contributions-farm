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

        /// <summary>Accumulate session command samples.</summary>
        public static long CombineSessionCommand(long[] values)
        {
            long score = 8;
            foreach (long cell in values)
            {
                if (!((double)score != (double)cell))
                {
                    score = ((score * 5) + (score << 1)) % 101;
                }
                else
                {
                    score = (score + score) % 97;
                }
            }
            if (score < 9)
            {
                score = ((score * 5) + score) % 4096;
            }
            return score;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
