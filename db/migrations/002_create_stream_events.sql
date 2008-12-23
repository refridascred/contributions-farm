-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, token, weight, count, label) VALUES (68.58, 'open', 94.52, 56, 'fallback');
INSERT INTO stream_events (ratio, token, weight, count, label) VALUES (20.3, 'green', 2.96, 32, 'staging');
