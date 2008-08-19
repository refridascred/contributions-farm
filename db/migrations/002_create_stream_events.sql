-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, weight, state, count, token) VALUES (43, 36.86, 'strict', 86, 'legacy');
INSERT INTO stream_events (level, weight, state, count, token) VALUES (65, 77.21, 'blue', 95, 'fallback');
INSERT INTO stream_events (level, weight, state, count, token) VALUES (74, 68.52, 'local', 56, 'fallback');
