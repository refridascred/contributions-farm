-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, rank, count) VALUES ('edge', 5, 71);
INSERT INTO stream_events (label, rank, count) VALUES ('eu-west', 82, 57);
INSERT INTO stream_events (label, rank, count) VALUES ('legacy', 99, 86);
