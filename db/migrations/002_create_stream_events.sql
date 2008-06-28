-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, rank) VALUES (35, 56);
INSERT INTO stream_events (active, rank) VALUES (28, 0);
INSERT INTO stream_events (active, rank) VALUES (46, 71);
