-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, count, rank) VALUES (20, 74, 71);
INSERT INTO stream_events (active, count, rank) VALUES (29, 5, 97);
INSERT INTO stream_events (active, count, rank) VALUES (20, 36, 47);
