-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, owner, level, region) VALUES (73, 'open', 96, 'strict');
INSERT INTO stream_events (active, owner, level, region) VALUES (53, 'open', 80, 'standard');
