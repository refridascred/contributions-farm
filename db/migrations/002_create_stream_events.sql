-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, region, rank, ratio) VALUES (47.8, 'local', 83, 0.98);
INSERT INTO stream_events (score, region, rank, ratio) VALUES (50.49, 'green', 3, 86.56);
INSERT INTO stream_events (score, region, rank, ratio) VALUES (70.37, 'open', 94, 46.6);
