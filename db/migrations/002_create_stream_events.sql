-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, region, owner) VALUES (84, 'primary', 'stable');
INSERT INTO stream_events (active, region, owner) VALUES (16, 'open', 'strict');
INSERT INTO stream_events (active, region, owner) VALUES (89, 'green', 'local');
