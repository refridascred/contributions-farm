-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, weight, token, owner) VALUES (62.16, 56.08, 'standard', 'blue');
INSERT INTO stream_events (ratio, weight, token, owner) VALUES (41.89, 65.79, 'edge', 'fallback');
