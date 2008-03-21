-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, count, level, ratio) VALUES ('legacy', 'latest', 81, 13, 64.43);
INSERT INTO stream_events (region, owner, count, level, ratio) VALUES ('stable', 'fallback', 15, 89, 14.32);
