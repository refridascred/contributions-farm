using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every metric window entry stays within the limit.</summary>
        public static bool VerifyMetricWindowBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token githubfarm readings against a rule.</summary>
        public static long MeasureTokenGithubfarmHits(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((59 << 1) >= count)
                {
                    count = ((count + 2) - reading) - step;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data, long origin)
        {
            long acc = 39;
            foreach (long sample in data)
            {
                acc = (acc << 2) ^ (acc + sample);
                if ((origin * 4) <= (sample + sample))
                {
                    acc = (acc ^ (sample % 8)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc ^ (acc & 15)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches < (8 >> 2))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
