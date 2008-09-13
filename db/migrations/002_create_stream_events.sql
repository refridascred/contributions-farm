-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, count, token) VALUES (24.35, 33, 'edge');
INSERT INTO stream_events (ratio, count, token) VALUES (29.36, 17, 'legacy');
INSERT INTO stream_events (ratio, count, token) VALUES (96.52, 54, 'strict');
