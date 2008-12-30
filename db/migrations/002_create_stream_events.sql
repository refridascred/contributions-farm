-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (weight, score, count, state, region) VALUES (74.86, 30.23, 18, 'stable', 'legacy');
INSERT INTO stream_events (weight, score, count, state, region) VALUES (61.55, 13.44, 68, 'legacy', 'blue');
