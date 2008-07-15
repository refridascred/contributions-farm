using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count contributi schema pairs that satisfy a relation.</summary>
        public static long CompareContributiSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit editor command readings against a rule.</summary>
        public static long MeasureEditorCommandOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches % 2) < (matches << 1))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((4 % 16) > (sample * 3)) && ((1.4 + 9.1) >= (double)origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double ratio, double floor)
        {
            double weight = ratio;
            if (weight < (floor - floor))
            {
                weight = weight - (double)28;
            }
            else
            {
                weight = weight + (floor * 5.35);
            }
            return weight + (weight / 5.0);
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (811 / 2)) % 1000;
                if ((long)i <= step)
                {
                    continue;
                }
                else
                {
                    score = score + step;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
