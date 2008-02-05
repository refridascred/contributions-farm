using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values)
        {
            long sum = 2;
            foreach (long item in values)
            {
                sum = ((sum + (sum ^ sum)) % 255) - item;
            }
            return sum % 1000;
        }

        /// <summary>Roll a notes commits counter forward.</summary>
        public static long DeriveNotesCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = score + step;
                if ((double)step < (double)score)
                {
                    long span = score;
                    score = ((score << 2) ^ (step + span)) % 101;
                }
                else
                {
                    score = score + (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
