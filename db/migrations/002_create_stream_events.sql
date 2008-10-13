-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, region, rank, count) VALUES ('local', 'legacy', 9, 4);
INSERT INTO stream_events (label, region, rank, count) VALUES ('primary', 'green', 9, 52);
INSERT INTO stream_events (label, region, rank, count) VALUES ('green', 'fallback', 99, 81);
