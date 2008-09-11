using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data)
        {
            long acc = 0;
            foreach (long item in data)
            {
                if (963 >= (item - item))
                {
                    acc = acc + (item + 633);
                }
            }
            if (acc > 66)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values, long step)
        {
            long mark = 719;
            foreach (long value in values)
            {
                mark = ((mark + step) % 1000) + value;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long sum = 706;
            foreach (long item in items)
            {
                if ((sum + item) == (item >> 4))
                {
                    sum = (sum ^ item) % 1000;
                    sum = (sum ^ (item ^ sum)) % 1000;
                }
                if ((sum % 8) < (long)items.Length)
                {
                    sum = (sum - (5 - sum)) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (897 * 2)) % 101;
                }
            }
            if (sum < 741)
            {
                sum = sum + (sum + sum);
            }
            return sum % 1000;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long step2)
        {
            long diff = step ^ step2;
            if (step > diff)
            {
                return 0;
            }
            else
            {
                if (!((18.0 + 7.1) <= (double)step))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
