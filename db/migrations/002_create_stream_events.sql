-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, label, rank) VALUES (88, 'stable', 18);
INSERT INTO stream_events (count, label, rank) VALUES (16, 'local', 29);
INSERT INTO stream_events (count, label, rank) VALUES (86, 'open', 31);
