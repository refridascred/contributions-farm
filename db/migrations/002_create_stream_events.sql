-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, count, score, region) VALUES (59.41, 88, 75.22, 'strict');
INSERT INTO stream_events (weight, count, score, region) VALUES (40.86, 15, 30.54, 'green');
INSERT INTO stream_events (weight, count, score, region) VALUES (24.92, 59, 65.74, 'local');
