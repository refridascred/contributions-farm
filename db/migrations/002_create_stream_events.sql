-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, ratio, active) VALUES (40, 34.14, 55);
INSERT INTO stream_events (count, ratio, active) VALUES (36, 43.76, 5);
INSERT INTO stream_events (count, ratio, active) VALUES (79, 27.12, 94);
