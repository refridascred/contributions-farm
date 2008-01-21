-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, owner, active) VALUES (25.11, 'stable', 69);
INSERT INTO stream_events (weight, owner, active) VALUES (33.98, 'local', 16);
INSERT INTO stream_events (weight, owner, active) VALUES (64.2, 'blue', 72);
