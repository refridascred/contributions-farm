-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, weight, count, ratio) VALUES (54, 67.32, 92, 7.15);
INSERT INTO stream_events (rank, weight, count, ratio) VALUES (26, 65.87, 47, 32.14);
