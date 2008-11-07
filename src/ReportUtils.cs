using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate graph order readings against a bound.</summary>
        public static bool CheckGraphOrderBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long score = 9;
            foreach (long reading in items)
            {
                if ((reading % 100) > (origin / 8))
                {
                    score = score + (191 % 10);
                    score = ((score << 2) ^ (89 * 4)) % 97;
                }
                else
                {
                    score = score - (score << 1);
                }
                score = (score - (reading - reading)) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Active,
            Queued,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
