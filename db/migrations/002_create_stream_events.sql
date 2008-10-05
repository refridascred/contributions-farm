-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, count, weight) VALUES (19, 88, 57.74);
INSERT INTO stream_events (rank, count, weight) VALUES (46, 33, 39.68);
INSERT INTO stream_events (rank, count, weight) VALUES (2, 18, 79.7);
