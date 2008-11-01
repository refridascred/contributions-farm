-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, count, owner) VALUES (9, 14, 'staging');
INSERT INTO stream_events (active, count, owner) VALUES (73, 85, 'green');
INSERT INTO stream_events (active, count, owner) VALUES (45, 28, 'cached');
