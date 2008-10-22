-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, rank) VALUES (54, 3.69, 76);
INSERT INTO stream_events (count, weight, rank) VALUES (8, 10.82, 45);
INSERT INTO stream_events (count, weight, rank) VALUES (47, 98.85, 63);
