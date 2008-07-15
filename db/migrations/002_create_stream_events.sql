-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, count, rank) VALUES (6.18, 75, 65);
INSERT INTO stream_events (ratio, count, rank) VALUES (86.93, 74, 89);
INSERT INTO stream_events (ratio, count, rank) VALUES (13.92, 59, 88);
