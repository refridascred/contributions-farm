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

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((46 - datum) > (datum ^ tally)) && (tally < (datum + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
