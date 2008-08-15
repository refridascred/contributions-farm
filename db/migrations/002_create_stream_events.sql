-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, active, region) VALUES ('stable', 80, 'strict');
