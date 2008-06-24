-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, region, count, label) VALUES (18, 'latest', 42, 'latest');
INSERT INTO stream_events (rank, region, count, label) VALUES (48, 'green', 9, 'legacy');
INSERT INTO stream_events (rank, region, count, label) VALUES (24, 'stable', 69, 'stable');
