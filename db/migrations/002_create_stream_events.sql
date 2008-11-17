-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, weight, active, owner, token) VALUES (62, 64.6, 2, 'green', 'staging');
INSERT INTO stream_events (count, weight, active, owner, token) VALUES (80, 21.1, 21, 'legacy', 'strict');
