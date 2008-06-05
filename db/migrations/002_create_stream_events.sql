-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, score, owner, weight, region) VALUES (55, 64.37, 'latest', 69.92, 'strict');
INSERT INTO stream_events (count, score, owner, weight, region) VALUES (4, 2.15, 'primary', 92.86, 'cached');
