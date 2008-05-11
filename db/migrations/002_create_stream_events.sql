-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, ratio, weight, token) VALUES (99, 72.08, 80.03, 'primary');
INSERT INTO stream_events (count, ratio, weight, token) VALUES (65, 62.34, 88.22, 'strict');
INSERT INTO stream_events (count, ratio, weight, token) VALUES (42, 27.7, 1.24, 'open');
