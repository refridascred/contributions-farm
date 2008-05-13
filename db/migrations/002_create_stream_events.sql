-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, rank, weight) VALUES (30.24, 44, 46.45);
INSERT INTO stream_events (ratio, rank, weight) VALUES (3.36, 22, 9.99);
INSERT INTO stream_events (ratio, rank, weight) VALUES (1.08, 8, 64.87);
