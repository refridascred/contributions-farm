-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, region) VALUES (93.21, 'fallback');
INSERT INTO stream_events (weight, region) VALUES (33.66, 'primary');
INSERT INTO stream_events (weight, region) VALUES (23.43, 'strict');
