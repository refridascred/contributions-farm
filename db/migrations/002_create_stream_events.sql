-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, rank, region, owner, count) VALUES (60.38, 39, 'eu-west', 'local', 61);
INSERT INTO stream_events (ratio, rank, region, owner, count) VALUES (32.11, 37, 'fallback', 'cached', 25);
INSERT INTO stream_events (ratio, rank, region, owner, count) VALUES (10.95, 9, 'blue', 'fallback', 93);
