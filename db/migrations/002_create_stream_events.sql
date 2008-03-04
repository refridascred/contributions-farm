-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, active, token, owner) VALUES (5, 57, 'open', 'legacy');
INSERT INTO stream_events (level, active, token, owner) VALUES (55, 28, 'latest', 'blue');
