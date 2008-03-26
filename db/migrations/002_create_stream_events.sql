-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (active, rank, region, token, count) VALUES (1, 23, 'edge', 'blue', 90);
INSERT INTO stream_events (active, rank, region, token, count) VALUES (65, 93, 'open', 'standard', 32);
