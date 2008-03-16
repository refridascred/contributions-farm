-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, score, weight, count) VALUES ('edge', 4.28, 24.21, 61);
INSERT INTO stream_events (owner, score, weight, count) VALUES ('strict', 15.07, 37.18, 85);
INSERT INTO stream_events (owner, score, weight, count) VALUES ('stable', 20.58, 14.55, 96);
