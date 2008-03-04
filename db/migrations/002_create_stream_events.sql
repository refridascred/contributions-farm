-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, active) VALUES ('staging', 48);
INSERT INTO stream_events (owner, active) VALUES ('local', 47);
INSERT INTO stream_events (owner, active) VALUES ('staging', 95);
