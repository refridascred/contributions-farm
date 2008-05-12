-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, count, ratio, label) VALUES (11, 67, 62.27, 'green');
INSERT INTO stream_events (active, count, ratio, label) VALUES (57, 52, 33.4, 'latest');
INSERT INTO stream_events (active, count, ratio, label) VALUES (60, 27, 56.15, 'green');
