-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, token, region, rank) VALUES (23, 'fallback', 'staging', 40);
INSERT INTO stream_events (level, token, region, rank) VALUES (51, 'stable', 'standard', 24);
INSERT INTO stream_events (level, token, region, rank) VALUES (59, 'local', 'fallback', 15);
