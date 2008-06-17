-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, rank, score, region) VALUES (53.3, 44, 16.67, 'legacy');
INSERT INTO stream_events (ratio, rank, score, region) VALUES (71.79, 17, 38.56, 'stable');
INSERT INTO stream_events (ratio, rank, score, region) VALUES (19.07, 93, 24.79, 'fallback');
