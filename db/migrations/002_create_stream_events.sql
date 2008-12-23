-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, level, label, token) VALUES (44, 11, 'staging', 'edge');
INSERT INTO stream_events (active, level, label, token) VALUES (73, 78, 'local', 'staging');
