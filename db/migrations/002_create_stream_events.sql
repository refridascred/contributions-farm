-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, state, token, weight, count) VALUES (85, 'eu-west', 'stable', 72.32, 75);
INSERT INTO stream_events (level, state, token, weight, count) VALUES (44, 'fallback', 'stable', 75.8, 50);
