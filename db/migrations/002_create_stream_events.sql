-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (level, active, label, token) VALUES (96, 79, 'latest', 'green');
INSERT INTO stream_events (level, active, label, token) VALUES (24, 51, 'stable', 'fallback');
