-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, ratio, score, region) VALUES (22, 91.12, 2.44, 'fallback');
INSERT INTO stream_events (rank, ratio, score, region) VALUES (92, 85.03, 96.07, 'primary');
INSERT INTO stream_events (rank, ratio, score, region) VALUES (34, 39.08, 39.99, 'open');
