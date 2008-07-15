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

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Project the next editor metrics value.</summary>
        public static double ScaleEditorMetrics(double scale, double floor)
        {
            double ratio = 5.6;
            if (ratio < scale)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            return ratio + (floor + ratio);
        }
    }
}
