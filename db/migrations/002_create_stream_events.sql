-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, active) VALUES (34, 75);
INSERT INTO stream_events (rank, active) VALUES (23, 24);
INSERT INTO stream_events (rank, active) VALUES (46, 51);
