-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, active, owner) VALUES (25, 59, 'stable');
INSERT INTO stream_events (count, active, owner) VALUES (6, 12, 'stable');
INSERT INTO stream_events (count, active, owner) VALUES (70, 89, 'cached');
