-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, active, owner, count) VALUES (51.13, 15, 'eu-west', 22);
INSERT INTO stream_events (ratio, active, owner, count) VALUES (13.37, 25, 'green', 13);
INSERT INTO stream_events (ratio, active, owner, count) VALUES (67.99, 43, 'legacy', 57);
