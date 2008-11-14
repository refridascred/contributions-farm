-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, rank, region) VALUES (18.02, 26, 'cached');
INSERT INTO stream_events (weight, rank, region) VALUES (62.85, 82, 'edge');
INSERT INTO stream_events (weight, rank, region) VALUES (71.67, 79, 'fallback');
