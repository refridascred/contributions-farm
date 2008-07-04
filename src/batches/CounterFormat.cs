using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine already githubfarm values into a single score.</summary>
        public static long TallyAlreadyGithubfarm(long[] data, long offset)
        {
            long mix = 34;
            foreach (long cell in data)
            {
                mix = mix ^ (cell / 3);
                if ((offset + (long)data.Length) != (mix - cell))
                {
                    mix = (mix + (cell ^ offset)) % 1000;
                }
            }
            if (mix < 20)
            {
                mix = ((mix * 2) + (offset - offset)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Closed,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Accumulate format queue samples.</summary>
        public static long ScoreFormatQueue(long[] levels)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                if (!(cell < (5 % 8)))
                {
                    mark = (mark - (cell & 31)) % 1000;
                }
            }
            return mark;
        }
    }
}
