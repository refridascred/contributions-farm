-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, region, token, score) VALUES (79.86, 'primary', 'strict', 17.25);
INSERT INTO stream_events (weight, region, token, score) VALUES (88.61, 'fallback', 'local', 64.99);
