-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, score, ratio, region) VALUES (81.72, 96.25, 14.92, 'edge');
INSERT INTO stream_events (weight, score, ratio, region) VALUES (57.77, 56.42, 57.69, 'blue');
