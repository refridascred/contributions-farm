-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, active, owner, score) VALUES (98.33, 39, 'fallback', 44.59);
INSERT INTO stream_events (weight, active, owner, score) VALUES (61.9, 99, 'strict', 62.51);
INSERT INTO stream_events (weight, active, owner, score) VALUES (49.58, 28, 'legacy', 47.93);
