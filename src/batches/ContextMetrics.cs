using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double bias)
        {
            double gain2 = (bias / 5.0) + (double)99;
            if (gain2 <= gain)
            {
                gain2 = gain2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - (gain * 9.9)) + (double)(long)i;
            }
            return gain2 - bias;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Done,
            Active,
            Ready,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                if (!((double)reading < (6.3 - 9.2)))
                {
                    anchor = (anchor << 2) ^ (8 >> 2);
                }
            }
            if (anchor > (-2))
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor % 65521;
        }
    }
}
