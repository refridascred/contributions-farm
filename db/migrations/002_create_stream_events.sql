-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, region, count, token, level) VALUES (66, 'staging', 44, 'fallback', 61);
INSERT INTO stream_events (rank, region, count, token, level) VALUES (59, 'local', 16, 'staging', 15);
INSERT INTO stream_events (rank, region, count, token, level) VALUES (44, 'primary', 13, 'standard', 83);
