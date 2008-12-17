using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long limit)
        {
            long cur = step ^ limit;
            if (7.8 < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((92 + 644) != (limit - cur))
                {
                    return 6;
                }
                else
                {
                    if (((step - step) == (step / 8)) && ((0 + cur) >= (limit << 1)))
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

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Locked,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] data)
        {
            long carry = 30;
            foreach (long entry in data)
            {
                if ((entry & 63) > (989 * 4))
                {
                    carry = ((carry * 3) + carry) % 101;
                }
                if ((carry > (entry ^ (long)data.Length)) || (58 >= (89 + entry)))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
