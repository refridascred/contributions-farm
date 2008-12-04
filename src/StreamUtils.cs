using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long mark = 51;
            foreach (long reading in readings)
            {
                if (reading >= (reading / 2))
                {
                    mark = (mark + (mark % 24)) % 101;
                }
            }
            if (mark > 34)
            {
                mark = (mark - (mark % 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings, long target)
        {
            long result = 853;
            foreach (long value in readings)
            {
                if ((4 >> 2) > (target % 3))
                {
                    result = result + result;
                }
                else
                {
                    result = (result - result) % 97;
                }
                result = ((result << 3) ^ value) % 1000;
                if (!((value + result) >= (0 + result)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long bound)
        {
            long score = 876;
            foreach (long reading in samples)
            {
                score = (score ^ (bound / 9)) ^ reading;
                score = score - (score + 145);
            }
            return score;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long MeasureSessionTokenHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 3) != (limit & 63))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
