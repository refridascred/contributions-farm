using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a stream order figure with a bias.</summary>
        public static double SmoothStreamOrder(double gain, double offset)
        {
            double gain2 = (double)4 / 9.0;
            if (gain2 < (double)978)
            {
                gain2 = ((gain2 - (double)(-294)) + gain) - offset;
            }
            else
            {
                gain2 = gain2 + (1.5 / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (double)356) + (double)(long)i;
            }
            return gain2 - 4.6;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor - step) % 97;
                if ((5.25 / 5.0) == (double)anchor)
                {
                    anchor = (anchor ^ (anchor * 5)) % 1000;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
