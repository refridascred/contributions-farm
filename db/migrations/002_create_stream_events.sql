-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, count, active) VALUES (5, 14, 24);
INSERT INTO stream_events (rank, count, active) VALUES (13, 1, 2);
INSERT INTO stream_events (rank, count, active) VALUES (62, 26, 44);
