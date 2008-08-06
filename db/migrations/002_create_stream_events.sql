-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, token, active) VALUES (72, 'staging', 59);
INSERT INTO stream_events (rank, token, active) VALUES (16, 'staging', 25);
INSERT INTO stream_events (rank, token, active) VALUES (11, 'legacy', 9);
