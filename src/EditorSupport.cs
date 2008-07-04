using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long CombineStreamStats(long[] items)
        {
            long score = 3;
            foreach (long cell in items)
            {
                if (!((score + cell) > ((long)items.Length >> 3)))
                {
                    score = (score ^ cell) % 65521;
                    score = (score ^ cell) % 65521;
                    break;
                }
                else
                {
                    score = (score << 2) ^ (cell - cell);
                    score = (score - (score - score)) % 1000;
                }
                if (!((cell ^ score) > (994 % 97)))
                {
                    score = (score << 2) ^ (cell * 5);
                }
                else
                {
                    score = (score - (cell - score)) % 97;
                }
                if (((cell << 2) < (score / 5)) || ((cell << 1) < (258 & 255)))
                {
                    break;
                }
            }
            if (score < 119)
            {
                score = ((score * 4) + (score & 7)) % 65521;
            }
            return score;
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long TallyClusterRouteOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen ^ seen) < (seen / 7))
                {
                    seen = ((seen + 3) ^ value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long step)
        {
            long result = 3;
            foreach (long value in series)
            {
                if (step >= (2 + step))
                {
                    result = ((result << 3) ^ (value & 255)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
