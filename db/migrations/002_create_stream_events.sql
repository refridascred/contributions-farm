-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, label, count, region, active) VALUES ('fallback', 'strict', 95, 'latest', 35);
INSERT INTO stream_events (owner, label, count, region, active) VALUES ('standard', 'primary', 95, 'blue', 65);
