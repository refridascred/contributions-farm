-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, owner, count, active, rank) VALUES (50.55, 'strict', 78, 13, 93);
