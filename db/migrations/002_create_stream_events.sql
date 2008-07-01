-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, state, token, rank, count) VALUES (24, 'primary', 'stable', 52, 58);
INSERT INTO stream_events (level, state, token, rank, count) VALUES (41, 'fallback', 'standard', 63, 74);
INSERT INTO stream_events (level, state, token, rank, count) VALUES (46, 'latest', 'legacy', 11, 74);
