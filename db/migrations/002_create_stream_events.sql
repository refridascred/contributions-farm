-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, rank, ratio, region) VALUES (29.65, 44, 12.76, 'blue');
INSERT INTO stream_events (score, rank, ratio, region) VALUES (36.42, 94, 32.59, 'stable');
INSERT INTO stream_events (score, rank, ratio, region) VALUES (67.61, 80, 52.9, 'primary');
