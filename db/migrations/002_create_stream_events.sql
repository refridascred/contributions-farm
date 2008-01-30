-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, count, state, level, ratio) VALUES (48, 47, 'blue', 58, 30.47);
INSERT INTO stream_events (rank, count, state, level, ratio) VALUES (42, 70, 'edge', 40, 78.89);
