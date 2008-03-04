-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, region, count, weight) VALUES ('standard', 'open', 32, 56.43);
INSERT INTO stream_events (state, region, count, weight) VALUES ('stable', 'fallback', 84, 39.88);
INSERT INTO stream_events (state, region, count, weight) VALUES ('standard', 'stable', 37, 55.28);
