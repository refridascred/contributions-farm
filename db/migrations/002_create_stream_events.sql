-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, count) VALUES (10.05, 78);
INSERT INTO stream_events (score, count) VALUES (61.42, 42);
INSERT INTO stream_events (score, count) VALUES (9.88, 96);
