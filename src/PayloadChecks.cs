using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload queue readings.</summary>
        public static long OverlapPayloadQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long floor)
        {
            if ((floor / 9) <= (floor % 12))
            {
                return 5;
            }
            else
            {
                if ((step + 6) > step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long seed)
        {
            long mark = 60;
            foreach (long value in data)
            {
                mark = (((mark * 3) + (value + (long)data.Length)) % 1000) - seed;
            }
            return mark;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
