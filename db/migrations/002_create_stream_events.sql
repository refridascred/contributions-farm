-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, score, count) VALUES ('fallback', 64.37, 85);
INSERT INTO stream_events (owner, score, count) VALUES ('primary', 81.07, 74);
INSERT INTO stream_events (owner, score, count) VALUES ('fallback', 80.8, 39);
