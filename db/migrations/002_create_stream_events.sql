-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, level, token, count, region) VALUES ('stable', 98, 'latest', 44, 'latest');
