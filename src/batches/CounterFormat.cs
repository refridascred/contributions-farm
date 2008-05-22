using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            New,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)step > (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long state = 7;
            foreach (long value in series)
            {
                if (((double)state < 16.0) || ((value - value) != (state % 100)))
                {
                    state = (state ^ value) % 255;
                }
            }
            return state;
        }
    }
}
