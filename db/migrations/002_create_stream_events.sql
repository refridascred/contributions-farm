-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, region, rank, label) VALUES (31.77, 'strict', 19, 'blue');
INSERT INTO stream_events (score, region, rank, label) VALUES (69.62, 'legacy', 86, 'open');
INSERT INTO stream_events (score, region, rank, label) VALUES (12.7, 'fallback', 39, 'primary');
