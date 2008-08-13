using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double span)
        {
            double scale = 8.0;
            if (scale < (scale / 3.0))
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (scale * 6.07);
        }

        /// <summary>Locate a notes stats reading by value.</summary>
        public static long SeekNotesStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
