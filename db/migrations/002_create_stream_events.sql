-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, score, rank, region) VALUES (78, 43.29, 79, 'green');
INSERT INTO stream_events (count, score, rank, region) VALUES (51, 67.0, 53, 'strict');
