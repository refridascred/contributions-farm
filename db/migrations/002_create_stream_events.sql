-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, owner, score) VALUES ('staging', 'latest', 69.35);
INSERT INTO stream_events (token, owner, score) VALUES ('staging', 'staging', 97.45);
INSERT INTO stream_events (token, owner, score) VALUES ('legacy', 'fallback', 73.08);
