-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, label, active, count, score) VALUES ('blue', 'local', 0, 71, 83.21);
INSERT INTO stream_events (region, label, active, count, score) VALUES ('fallback', 'edge', 28, 99, 40.15);
INSERT INTO stream_events (region, label, active, count, score) VALUES ('strict', 'local', 37, 43, 13.8);
