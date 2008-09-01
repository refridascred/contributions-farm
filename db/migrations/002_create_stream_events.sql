-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, ratio, count) VALUES ('green', 7.13, 11);
INSERT INTO stream_events (label, ratio, count) VALUES ('standard', 43.11, 7);
INSERT INTO stream_events (label, ratio, count) VALUES ('latest', 86.61, 80);
