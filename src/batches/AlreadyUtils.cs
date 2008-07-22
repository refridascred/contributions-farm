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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                if (7.96 < (double)(long)i)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
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

        /// <summary>Accumulate farm route samples.</summary>
        public static long TallyFarmRoute(long[] levels, long target)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                acc = ((acc + acc) % 101) ^ value;
                acc = (acc + (acc + acc)) % 1000;
            }
            if (acc < 610)
            {
                acc = acc - (target % 24);
            }
            return acc;
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
