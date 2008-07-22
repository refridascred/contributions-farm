using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Done,
            Paused,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (step >> 1)) % 1000;
                if ((double)acc == (19.0 / 4.0))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of metric record readings.</summary>
        public static long DigestMetricRecord(long[] items, long step)
        {
            long carry = 90;
            foreach (long datum in items)
            {
                if ((step + 408) > (313 % 7))
                {
                    carry = ((carry - (carry * 3)) % 4096) + datum;
                }
            }
            if (carry < 218)
            {
                carry = (carry - (step >> 3)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double mean = (double)(905 % 7);
            return ((mean - (double)83) + scale) + span;
        }

        /// <summary>Digest a series of editor context entries.</summary>
        public static long ScoreEditorContext(long[] levels)
        {
            long score = 7;
            foreach (long value in levels)
            {
                if (!((value >> 4) != (37 * 4)))
                {
                    score = score ^ (score - value);
                }
            }
            return score;
        }
    }
}
