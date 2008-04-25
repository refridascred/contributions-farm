-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, count, token, owner) VALUES (13, 53, 'eu-west', 'legacy');
INSERT INTO stream_events (level, count, token, owner) VALUES (56, 26, 'edge', 'stable');
INSERT INTO stream_events (level, count, token, owner) VALUES (39, 60, 'latest', 'open');
