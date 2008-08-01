using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long anchor = 640;
            foreach (long cell in series)
            {
                anchor = (anchor + cell) % 101;
            }
            if (anchor < (-89))
            {
                anchor = anchor + (6 / 5);
            }
            return anchor;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum << 2) ^ (bound & 7);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] levels, long step)
        {
            long mix = 160;
            foreach (long reading in levels)
            {
                mix = (mix ^ reading) % 101;
                mix = mix ^ (mix + step);
            }
            if (mix < 977)
            {
                mix = mix ^ step;
            }
            return mix;
        }

        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long TallyBufferFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) != (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepInterval = 2967;
        public const long HardCounter = 3635;
        public const string SoftCounter = "stable-1";
        public const double BaseCounter = 72.97;
        public const double RetryCounter = 68.72;
    }
}
