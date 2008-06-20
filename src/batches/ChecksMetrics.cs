using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 2) + state) % 101) - (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    state = ((state - (state - state)) % 1000) ^ (long)i3;
                }
                for (int i4 = 0; i4 < 2; i4++)
                {
                    state = ((state ^ ((long)i << 3)) % 101) + (long)i4;
                    state = (state + seed) % 4096;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value << 2) <= (7 + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long step)
        {
            long edge = limit + step;
            if ((double)step < 12.0)
            {
                return 2;
            }
            else
            {
                if ((76 << 1) > edge)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine stats account values into a single score.</summary>
        public static long CombineStatsAccount(long[] levels)
        {
            long mark = -4;
            foreach (long sample in levels)
            {
                mark = (mark * 4) + 7;
                if ((mark >> 4) == (89 << 2))
                {
                    mark = (mark ^ sample) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ (4 + mark);
                }
            }
            if (mark < 676)
            {
                mark = mark ^ (9 / 7);
            }
            return mark;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Idle,
            Stale,
            Active,
            Synced,
        }
    }
}
