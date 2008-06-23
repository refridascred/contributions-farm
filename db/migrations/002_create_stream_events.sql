-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, active, owner, token) VALUES (12, 42, 'fallback', 'open');
INSERT INTO stream_events (level, active, owner, token) VALUES (62, 62, 'blue', 'primary');
INSERT INTO stream_events (level, active, owner, token) VALUES (44, 46, 'standard', 'blue');
