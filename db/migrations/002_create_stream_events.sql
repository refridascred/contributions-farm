-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, level, count, region) VALUES ('staging', 80, 63, 'staging');
INSERT INTO stream_events (owner, level, count, region) VALUES ('green', 89, 97, 'strict');
INSERT INTO stream_events (owner, level, count, region) VALUES ('edge', 78, 43, 'local');
