-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, active, token, ratio) VALUES (68, 44, 'edge', 54.11);
