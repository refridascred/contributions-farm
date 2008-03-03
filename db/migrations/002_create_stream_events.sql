-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, ratio, label, active) VALUES (73, 75.43, 'green', 71);
INSERT INTO stream_events (count, ratio, label, active) VALUES (99, 6.37, 'strict', 52);
INSERT INTO stream_events (count, ratio, label, active) VALUES (6, 33.28, 'staging', 27);
