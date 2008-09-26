-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, token, count, region, ratio) VALUES (95, 'strict', 39, 'staging', 65.99);
INSERT INTO stream_events (rank, token, count, region, ratio) VALUES (50, 'fallback', 6, 'standard', 5.04);
INSERT INTO stream_events (rank, token, count, region, ratio) VALUES (55, 'strict', 36, 'stable', 61.01);
