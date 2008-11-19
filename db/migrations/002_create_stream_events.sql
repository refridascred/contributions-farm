-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, weight, state, region) VALUES (58, 89.42, 'green', 'cached');
INSERT INTO stream_events (level, weight, state, region) VALUES (44, 10.17, 'fallback', 'legacy');
