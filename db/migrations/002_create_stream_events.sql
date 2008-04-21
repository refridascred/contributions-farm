-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, count, active) VALUES (42, 'green', 67, 22);
INSERT INTO stream_events (rank, label, count, active) VALUES (53, 'stable', 31, 2);
INSERT INTO stream_events (rank, label, count, active) VALUES (15, 'local', 68, 30);
