-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, owner, active) VALUES (69, 'latest', 67);
INSERT INTO stream_events (count, owner, active) VALUES (27, 'standard', 23);
