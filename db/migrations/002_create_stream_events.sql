-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, weight, region) VALUES (34, 98.21, 'stable');
INSERT INTO stream_events (rank, weight, region) VALUES (53, 89.37, 'fallback');
