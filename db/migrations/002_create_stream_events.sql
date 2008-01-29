-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, level, count, region) VALUES ('edge', 11, 6, 'strict');
INSERT INTO stream_events (owner, level, count, region) VALUES ('cached', 56, 4, 'staging');
INSERT INTO stream_events (owner, level, count, region) VALUES ('edge', 19, 47, 'edge');
