-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, count, owner, label) VALUES (4, 29, 'latest', 'latest');
INSERT INTO stream_events (active, count, owner, label) VALUES (73, 15, 'strict', 'blue');
INSERT INTO stream_events (active, count, owner, label) VALUES (52, 23, 'staging', 'stable');
