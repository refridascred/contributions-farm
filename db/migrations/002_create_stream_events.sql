-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, ratio, region, count) VALUES (37.0, 52.65, 'primary', 30);
INSERT INTO stream_events (weight, ratio, region, count) VALUES (61.94, 69.71, 'staging', 67);
