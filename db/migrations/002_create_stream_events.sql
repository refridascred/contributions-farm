-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, region, weight, score) VALUES (20, 'primary', 55.23, 86.41);
INSERT INTO stream_events (active, region, weight, score) VALUES (71, 'edge', 15.15, 66.41);
INSERT INTO stream_events (active, region, weight, score) VALUES (64, 'blue', 61.12, 31.99);
