-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, active, score) VALUES ('staging', 3, 85.01);
INSERT INTO stream_events (token, active, score) VALUES ('fallback', 71, 84.96);
INSERT INTO stream_events (token, active, score) VALUES ('edge', 98, 20.69);
