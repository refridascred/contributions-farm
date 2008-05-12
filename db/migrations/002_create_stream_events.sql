-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, count, weight, token) VALUES ('staging', 9, 24.52, 'edge');
INSERT INTO stream_events (region, count, weight, token) VALUES ('edge', 76, 13.8, 'open');
