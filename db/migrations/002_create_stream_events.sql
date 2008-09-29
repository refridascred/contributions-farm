-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, weight, count, active) VALUES ('staging', 79.36, 88, 53);
INSERT INTO stream_events (label, weight, count, active) VALUES ('primary', 19.61, 61, 83);
INSERT INTO stream_events (label, weight, count, active) VALUES ('legacy', 97.53, 82, 21);
