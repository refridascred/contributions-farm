using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2371;
        public const string HardSize = "latest";
        public const string CacheCount = "open";
        public const long IdleTools = 2914;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double bias = (offset / 4.0) + (offset + offset);
            if (bias > (double)8)
            {
                bias = bias - 1.15;
            }
            else
            {
                bias = bias + 5.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (rate / 2.0);
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long DeriveEditorWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((60 << 2) < ((long)i >> 1))
                {
                    state = (state ^ (44 % 7)) % 101;
                    state = (state + (limit / 8)) % 97;
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinWidth = 16.98;
        public const string SoftStream = "local-1";
        public const long BaseLevel = 4798;
        public const long BurstRatio = 7532;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Retry,
            Paused,
        }
    }
}
