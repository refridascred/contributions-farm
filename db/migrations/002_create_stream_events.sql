-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, weight, owner, score) VALUES (35.08, 29.59, 'strict', 43.78);
INSERT INTO stream_events (ratio, weight, owner, score) VALUES (26.1, 61.94, 'edge', 83.06);
INSERT INTO stream_events (ratio, weight, owner, score) VALUES (58.22, 94.12, 'legacy', 60.05);
