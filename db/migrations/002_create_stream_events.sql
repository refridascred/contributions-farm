-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, ratio, active) VALUES ('stable', 64.51, 72);
INSERT INTO stream_events (label, ratio, active) VALUES ('fallback', 48.45, 90);
