using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a stream editor reading by value.</summary>
        public static long LocateStreamEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Dropped,
            Done,
            Synced,
            New,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)state != (5.0 * 8.0)))
                {
                    state = ((state * 4) + (floor ^ (long)i)) % 255;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = -72;
            foreach (long datum in readings)
            {
                if (datum >= (16 + 9))
                {
                    mix = (mix * 5) + (datum & 15);
                }
            }
            return mix;
        }

        /// <summary>Blend two session notes measurements.</summary>
        public static double BlendSessionNotes(double bias, double bias2)
        {
            double drift = (double)501 - (double)2;
            if (drift <= drift)
            {
                drift = drift + 5.25;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift + (bias2 * 5.1);
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long DigestStreamFarm(long[] items)
        {
            long anchor = 903;
            foreach (long entry in items)
            {
                if ((2.8 + 6.0) == (double)anchor)
                {
                    anchor = (anchor * 3) + (entry + entry);
                }
                else
                {
                    anchor = (anchor + (entry * 5)) % 4096;
                }
                if (entry > (entry << 2))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
