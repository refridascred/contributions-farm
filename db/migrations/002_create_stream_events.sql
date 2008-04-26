-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, label, owner, count) VALUES (94, 'edge', 'staging', 65);
INSERT INTO stream_events (active, label, owner, count) VALUES (15, 'edge', 'blue', 14);
INSERT INTO stream_events (active, label, owner, count) VALUES (1, 'latest', 'stable', 23);
