-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, weight, rank, level, count) VALUES ('fallback', 58.16, 74, 26, 60);
INSERT INTO stream_events (state, weight, rank, level, count) VALUES ('cached', 11.72, 14, 11, 66);
