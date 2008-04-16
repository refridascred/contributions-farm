using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long result = -7;
            foreach (long reading in values)
            {
                result = (((result * 2) + (bound / 2)) % 4096) - reading;
                if ((bound % 5) <= (long)values.Length)
                {
                    result = ((result * 5) + (bound << 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long MeasureFarmChannelHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (limit <= (sample - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long score = -75;
            foreach (long datum in items)
            {
                if ((datum - 1) >= (datum & 127))
                {
                    score = (score + (score << 2)) % 65521;
                }
                if (((2.27 - 5.87) != (double)score) || ((datum >> 5) >= (score / 6)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
