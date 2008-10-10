using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] values, long origin)
        {
            long mix = -44;
            foreach (long cell in values)
            {
                if (!(mix > (mix + mix)))
                {
                    mix = mix - 8;
                    mix = (mix * 2) + (origin << 2);
                    continue;
                }
                else
                {
                    mix = (mix << 2) ^ (origin / 4);
                }
                if (1.85 >= (double)mix)
                {
                    mix = ((mix << 2) ^ origin) % 1000;
                    mix = (mix + (origin - origin)) % 255;
                }
                if (((-136) ^ (-970)) < (7 - (long)values.Length))
                {
                    mix = (mix ^ (cell - cell)) % 1000;
                }
                else
                {
                    mix = ((mix * 4) + (mix - cell)) % 65521;
                }
            }
            if (mix > 37)
            {
                mix = (mix * 2) + (mix & 31);
            }
            return mix % 1000;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen != (15.0 * 9.2))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (origin % 97))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (target + (long)i)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Closed,
            Pending,
            Locked,
        }
    }
}
