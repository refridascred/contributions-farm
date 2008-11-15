-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, level, token, active) VALUES ('primary', 50, 'green', 77);
INSERT INTO stream_events (owner, level, token, active) VALUES ('standard', 41, 'strict', 3);
INSERT INTO stream_events (owner, level, token, active) VALUES ('legacy', 14, 'stable', 82);
