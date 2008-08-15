-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, active, count, label) VALUES (80.85, 43, 31, 'eu-west');
INSERT INTO stream_events (ratio, active, count, label) VALUES (16.52, 42, 68, 'blue');
INSERT INTO stream_events (ratio, active, count, label) VALUES (33.67, 77, 0, 'open');
