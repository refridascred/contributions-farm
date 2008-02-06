-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, ratio, label) VALUES (99, 23.59, 'fallback');
INSERT INTO stream_events (count, ratio, label) VALUES (18, 84.49, 'local');
