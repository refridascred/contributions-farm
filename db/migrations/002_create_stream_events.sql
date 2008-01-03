-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, count, rank) VALUES (12.94, 16, 14);
INSERT INTO stream_events (ratio, count, rank) VALUES (8.07, 85, 20);
INSERT INTO stream_events (ratio, count, rank) VALUES (61.64, 49, 54);
