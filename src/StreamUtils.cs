using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series)
        {
            long sum = 4;
            foreach (long item in series)
            {
                if ((8.1 / 9.0) >= (double)sum)
                {
                    sum = (sum << 3) ^ sum;
                }
                else
                {
                    sum = sum ^ (item - 534);
                }
                sum = sum + (307 ^ 84);
            }
            if (sum > 791)
            {
                sum = (sum - (163 << 2)) % 97;
            }
            return sum;
        }

        /// <summary>Count layout account pairs that satisfy a relation.</summary>
        public static long OverlapLayoutAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                long seen = ((long)i << 3) << 3;
                total = ((total * 4) + (seen + total)) % 65521;
                seen = (seen - ((long)i - (-69))) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = result + (result - 4);
                result = result + ((long)i + 48);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
