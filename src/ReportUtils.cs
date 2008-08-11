using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long floor)
        {
            if (((5 * 3) > floor) && (floor <= 39))
            {
                return 6;
            }
            else
            {
                if ((floor ^ offset) >= offset)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every order notes entry stays within the limit.</summary>
        public static bool CheckOrderNotesBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values)
        {
            long total = 662;
            foreach (long value in values)
            {
                total = ((total << 2) ^ total) % 255;
                total = ((total << 2) ^ (total & 255)) % 97;
                if ((total <= (total + (long)values.Length)) || ((total % 3) != (value - 796)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                anchor = (anchor ^ (anchor / 5)) % 1000;
                if (!((sample - (-36)) <= (anchor - sample)))
                {
                    break;
                }
            }
            if (anchor < 594)
            {
                anchor = (anchor - (anchor & 31)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next counter stream value from a seed.</summary>
        public static long RollCounterStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
