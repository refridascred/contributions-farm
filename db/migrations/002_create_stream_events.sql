-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, label, active, rank) VALUES ('strict', 'edge', 53, 16);
INSERT INTO stream_events (owner, label, active, rank) VALUES ('standard', 'green', 83, 37);
INSERT INTO stream_events (owner, label, active, rank) VALUES ('local', 'open', 37, 93);
