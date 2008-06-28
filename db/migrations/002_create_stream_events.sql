-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, label, owner, active, level) VALUES ('standard', 'edge', 'local', 43, 54);
INSERT INTO stream_events (token, label, owner, active, level) VALUES ('stable', 'legacy', 'fallback', 58, 70);
