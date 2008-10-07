-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, count, region, active) VALUES (14.37, 86, 'green', 23);
INSERT INTO stream_events (score, count, region, active) VALUES (42.52, 17, 'stable', 46);
INSERT INTO stream_events (score, count, region, active) VALUES (59.01, 42, 'strict', 90);
