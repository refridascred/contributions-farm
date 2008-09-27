using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Closed,
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor - (7 + (long)i);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two payload stream measurements.</summary>
        public static double AdjustPayloadStream(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 <= (bias + bias2))
            {
                bias2 = bias2 - span;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (9.0 - 1.6);
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Failed,
            New,
            Queued,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] samples, long step)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = (score - item) % 1000;
                if (!((0.9 / 3.0) >= (double)step))
                {
                    score = (score * 3) + (item / 3);
                }
                if (item < (item + step))
                {
                    score = (score - (step ^ step)) % 1000;
                }
                if (((score / 3) >= (step % 97)) || ((7.5 * 8.5) <= (double)score))
                {
                    break;
                }
            }
            if (score > 73)
            {
                score = score - (step << 1);
            }
            return score;
        }
    }
}
