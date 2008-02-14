using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session record samples are out of range.</summary>
        public static long MeasureSessionRecordMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) <= (8 % 24))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine filter route values into a single score.</summary>
        public static long DigestFilterRoute(long[] readings)
        {
            long sum = -67;
            foreach (long reading in readings)
            {
                if (((double)sum < 18.0) && (sum >= (sum % 12)))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 1000;
                    sum = (sum ^ (971 + reading)) % 97;
                }
                if (6.86 < (double)reading)
                {
                    sum = sum + (sum - reading);
                }
            }
            if (sum < 9)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples, long bound)
        {
            long mix = 9;
            foreach (long datum in samples)
            {
                mix = ((mix ^ (4 ^ bound)) % 4096) - datum;
            }
            return mix;
        }

        /// <summary>Derive the next githubfarm editor value from a seed.</summary>
        public static long DeriveGithubfarmEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (acc - acc)) % 97;
                acc = (acc * 4) + target;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
