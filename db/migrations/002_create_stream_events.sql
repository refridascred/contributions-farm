-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, region, score) VALUES (80, 'stable', 73.78);
INSERT INTO stream_events (count, region, score) VALUES (78, 'legacy', 45.76);
INSERT INTO stream_events (count, region, score) VALUES (1, 'standard', 83.18);
