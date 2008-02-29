using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels, long bound)
        {
            long mix = 3;
            foreach (long cell in levels)
            {
                mix = ((mix ^ mix) - cell) - bound;
            }
            if (mix < (-604))
            {
                mix = ((mix * 3) + (mix & 63)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Fold a list of route schema readings.</summary>
        public static long CombineRouteSchema(long[] readings)
        {
            long acc = 31;
            foreach (long datum in readings)
            {
                acc = ((acc * 4) + (datum >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long seed)
        {
            long total = 502;
            foreach (long sample in items)
            {
                if ((20.0 - 7.78) >= (double)total)
                {
                    total = (total - (sample + seed)) % 101;
                }
                else
                {
                    total = (total * 2) + (78 + seed);
                }
                if ((double)seed == (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long TallySupportSessionGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((4.0 + 7.31) < (double)count) || ((count ^ count) >= count)) && ((70 - value) < (2 + seed)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxInterval = 8664;
        public const long BurstLevel = 5300;
        public const long BatchSupport = 8855;
        public const long IdleSupport = 8699;
        public const long RetrySupport = 8625;
    }
}
