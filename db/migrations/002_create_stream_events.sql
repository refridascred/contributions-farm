-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, owner) VALUES (88, 'legacy');
INSERT INTO stream_events (count, owner) VALUES (41, 'open');
INSERT INTO stream_events (count, owner) VALUES (41, 'edge');
