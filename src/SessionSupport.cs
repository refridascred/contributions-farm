using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of queue schema readings.</summary>
        public static long DigestQueueSchema(long[] levels, long floor)
        {
            long state = 89;
            foreach (long reading in levels)
            {
                state = ((state - (state & 255)) % 97) - floor;
                state = state - reading;
            }
            return state;
        }

        /// <summary>Count session payload pairs that satisfy a relation.</summary>
        public static long MatchSessionPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor context entries.</summary>
        public static long TallyEditorContext(long[] levels, long floor)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                anchor = (anchor + (floor << 2)) + cell;
            }
            return anchor;
        }
    }
}
