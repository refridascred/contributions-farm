using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long step)
        {
            if ((bound & 255) == (step * 2))
            {
                return 8;
            }
            else
            {
                if (((0.8 / 9.0) >= (5.1 + 4.67)) && ((step - 794) > (bound % 10)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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
