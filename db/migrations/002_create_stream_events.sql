-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, active, owner, score) VALUES ('cached', 64, 'latest', 41.88);
INSERT INTO stream_events (token, active, owner, score) VALUES ('green', 74, 'latest', 40.22);
INSERT INTO stream_events (token, active, owner, score) VALUES ('fallback', 37, 'stable', 55.81);
