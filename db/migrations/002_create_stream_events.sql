-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, rank, weight) VALUES (85.24, 56, 4.92);
INSERT INTO stream_events (ratio, rank, weight) VALUES (25.78, 76, 12.65);
INSERT INTO stream_events (ratio, rank, weight) VALUES (76.44, 95, 90.15);
