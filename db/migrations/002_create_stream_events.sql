-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, region, count, rank) VALUES ('open', 'green', 95, 48);
INSERT INTO stream_events (owner, region, count, rank) VALUES ('strict', 'local', 27, 8);
INSERT INTO stream_events (owner, region, count, rank) VALUES ('fallback', 'stable', 19, 50);
