-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, owner, rank) VALUES (1, 'stable', 23);
INSERT INTO stream_events (active, owner, rank) VALUES (78, 'local', 89);
