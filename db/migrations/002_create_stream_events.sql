-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, count, owner, level) VALUES (36.23, 14, 'edge', 88);
INSERT INTO stream_events (weight, count, owner, level) VALUES (78.18, 50, 'strict', 31);
INSERT INTO stream_events (weight, count, owner, level) VALUES (70.33, 86, 'edge', 2);
