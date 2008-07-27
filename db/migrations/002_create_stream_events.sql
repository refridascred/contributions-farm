-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, level, owner, label) VALUES ('staging', 28, 'fallback', 'cached');
INSERT INTO stream_events (token, level, owner, label) VALUES ('standard', 95, 'stable', 'standard');
INSERT INTO stream_events (token, level, owner, label) VALUES ('local', 45, 'legacy', 'cached');
