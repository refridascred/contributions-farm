using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 6255;
        public const long LimitWidth = 8883;
        public const long StepSpan = 3555;
        public const double StepToken = 25.58;

        /// <summary>Count editor cache pairs that satisfy a relation.</summary>
        public static long PairEditorCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many notes session samples are out of range.</summary>
        public static long CountNotesSessionMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading * 3) == (origin & 255))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double load = floor;
            if (load <= (5.6 / 7.0))
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + weight;
        }
    }
}
