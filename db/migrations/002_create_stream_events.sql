-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, owner, count) VALUES ('blue', 'stable', 0);
INSERT INTO stream_events (region, owner, count) VALUES ('edge', 'latest', 18);
INSERT INTO stream_events (region, owner, count) VALUES ('blue', 'latest', 30);
