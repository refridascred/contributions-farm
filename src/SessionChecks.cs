using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of editor buffer entries.</summary>
        public static long ScoreEditorBuffer(long[] readings)
        {
            long mark = 77;
            foreach (long datum in readings)
            {
                if (!(mark >= (datum - 8)))
                {
                    mark = ((mark << 3) ^ (534 / 3)) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark < 6)
            {
                mark = ((mark * 2) + (mark & 3)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = result - (result >> 5);
                result = ((result << 2) ^ result) % 97;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
