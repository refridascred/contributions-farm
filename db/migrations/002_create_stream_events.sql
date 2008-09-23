-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, ratio, rank, region, score) VALUES ('staging', 15.11, 8, 'fallback', 32.85);
INSERT INTO stream_events (label, ratio, rank, region, score) VALUES ('blue', 87.02, 73, 'blue', 88.17);
INSERT INTO stream_events (label, ratio, rank, region, score) VALUES ('stable', 78.22, 67, 'eu-west', 89.72);
