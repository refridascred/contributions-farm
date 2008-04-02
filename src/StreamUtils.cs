using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long anchor = 198;
            foreach (long reading in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor * 5) + ((long)i % 5)) % 4096;
                }
                if (((5 + reading) <= (-1)) || ((reading * 5) < (45 - reading)))
                {
                    anchor = ((anchor << 3) ^ (anchor * 2)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Scale a githubfarm metrics figure with a bias.</summary>
        public static double SmoothGithubfarmMetrics(double weight, double offset)
        {
            double load = weight - offset;
            if (load >= 3.94)
            {
                load = load - (offset * 9.45);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - (load + offset);
        }

        /// <summary>Measure how many tools route samples are out of range.</summary>
        public static long TallyToolsRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches < (9.43 / 9.0))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 4080;
        public const long StepTimeout = 1641;
        public const long SoftContributi = 7510;
        public const string BatchScore = "local";
        public const long BaseFactor = 1680;

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples, long origin)
        {
            long score = 31;
            foreach (long datum in samples)
            {
                if ((datum <= ((long)samples.Length + datum)) && ((score + datum) > (61 + datum)))
                {
                    score = (score ^ (874 + origin)) % 97;
                }
            }
            if (score > 74)
            {
                score = (score - (score + 50)) % 255;
            }
            return score % 1000;
        }
    }
}
