-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, count, owner, level) VALUES (5.14, 44, 'cached', 89);
INSERT INTO stream_events (ratio, count, owner, level) VALUES (57.99, 53, 'legacy', 51);
