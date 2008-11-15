-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, level, weight, score) VALUES (44, 22, 33.92, 26.04);
INSERT INTO stream_events (count, level, weight, score) VALUES (3, 20, 91.5, 12.0);
INSERT INTO stream_events (count, level, weight, score) VALUES (53, 3, 62.77, 86.44);
