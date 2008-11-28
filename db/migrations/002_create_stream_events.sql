-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, level, rank, count, owner) VALUES ('staging', 68, 84, 31, 'legacy');
INSERT INTO stream_events (region, level, rank, count, owner) VALUES ('local', 79, 6, 99, 'latest');
