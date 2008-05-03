-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, active, level, token) VALUES ('staging', 4, 18, 'legacy');
INSERT INTO stream_events (label, active, level, token) VALUES ('edge', 12, 37, 'legacy');
INSERT INTO stream_events (label, active, level, token) VALUES ('green', 84, 74, 'latest');
