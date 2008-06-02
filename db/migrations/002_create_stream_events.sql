-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, owner, token) VALUES (70, 'strict', 'legacy');
INSERT INTO stream_events (level, owner, token) VALUES (80, 'local', 'stable');
