-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, state, count, ratio, level) VALUES (60, 'strict', 52, 25.31, 69);
INSERT INTO stream_events (rank, state, count, ratio, level) VALUES (60, 'cached', 88, 60.33, 24);
INSERT INTO stream_events (rank, state, count, ratio, level) VALUES (42, 'stable', 90, 64.44, 35);
