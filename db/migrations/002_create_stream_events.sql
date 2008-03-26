-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, count, region, rank) VALUES ('staging', 80, 'green', 40);
INSERT INTO stream_events (label, count, region, rank) VALUES ('stable', 63, 'latest', 2);
INSERT INTO stream_events (label, count, region, rank) VALUES ('green', 5, 'edge', 79);
