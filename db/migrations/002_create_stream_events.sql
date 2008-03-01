-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, region) VALUES (4.54, 'staging');
INSERT INTO stream_events (weight, region) VALUES (58.21, 'legacy');
INSERT INTO stream_events (weight, region) VALUES (58.03, 'stable');
