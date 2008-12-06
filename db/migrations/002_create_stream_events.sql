-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, ratio, active) VALUES ('eu-west', 58.94, 43);
INSERT INTO stream_events (label, ratio, active) VALUES ('edge', 48.0, 54);
