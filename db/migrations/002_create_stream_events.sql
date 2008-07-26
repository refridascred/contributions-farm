-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, rank, active) VALUES ('primary', 30, 5);
INSERT INTO stream_events (label, rank, active) VALUES ('edge', 37, 67);
INSERT INTO stream_events (label, rank, active) VALUES ('primary', 11, 50);
