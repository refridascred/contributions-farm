-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, rank, region, ratio) VALUES (0, 92, 'latest', 23.56);
INSERT INTO stream_events (count, rank, region, ratio) VALUES (84, 89, 'legacy', 95.01);
