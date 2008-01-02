-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, level, region, owner, label) VALUES (41, 60, 'standard', 'local', 'strict');
INSERT INTO stream_events (count, level, region, owner, label) VALUES (44, 73, 'staging', 'standard', 'legacy');
