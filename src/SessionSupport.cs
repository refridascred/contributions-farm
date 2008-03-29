using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double span)
        {
            double rate = gain;
            return (rate + 2.07) + span;
        }

        /// <summary>Match up editor context samples.</summary>
        public static long PairEditorContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
