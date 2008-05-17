-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, weight, rank) VALUES (56, 26.84, 14);
INSERT INTO stream_events (count, weight, rank) VALUES (57, 12.92, 68);
INSERT INTO stream_events (count, weight, rank) VALUES (10, 28.08, 1);
