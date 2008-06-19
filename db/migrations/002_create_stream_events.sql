-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, rank, count) VALUES (88, 38, 43);
INSERT INTO stream_events (active, rank, count) VALUES (59, 6, 16);
INSERT INTO stream_events (active, rank, count) VALUES (81, 70, 42);
