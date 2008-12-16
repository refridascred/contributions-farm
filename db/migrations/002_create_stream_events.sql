-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, owner, active) VALUES (90, 'fallback', 12);
INSERT INTO stream_events (count, owner, active) VALUES (49, 'legacy', 39);
INSERT INTO stream_events (count, owner, active) VALUES (62, 'strict', 97);
