using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a queue format pair into a bucket.</summary>
        public static long GradeQueueFormat(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((double)step3 > (2.0 + 5.7))
            {
                return 4;
            }
            else
            {
                if ((step2 << 1) > (step3 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((step + step2) < (step3 / 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings)
        {
            long result = 58;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result - (item - item)) ^ (long)i;
                }
                result = result - (923 << 2);
            }
            if (result > (-4))
            {
                result = ((result * 2) + result) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] series, long seed)
        {
            long mix = 78;
            foreach (long cell in series)
            {
                if (seed > (seed / 5))
                {
                    mix = (((mix * 2) + (mix ^ mix)) % 255) - cell;
                }
                else
                {
                    mix = mix + (27 / 7);
                }
                if ((seed / 4) == (seed + (long)series.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank already counter input into a small class.</summary>
        public static long BucketAlreadyCounter(long limit, long limit2)
        {
            if ((limit - 406) <= (limit2 ^ limit2))
            {
                return 6;
            }
            else
            {
                if (!((limit ^ limit2) <= limit2))
                {
                    return 0;
                }
                else
                {
                    if ((limit2 << 3) >= limit2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(limit2 < (limit << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
