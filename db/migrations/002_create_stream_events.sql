-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, weight, count, active, token) VALUES ('strict', 80.35, 79, 39, 'staging');
INSERT INTO stream_events (label, weight, count, active, token) VALUES ('eu-west', 76.06, 55, 37, 'eu-west');
INSERT INTO stream_events (label, weight, count, active, token) VALUES ('fallback', 66.6, 49, 74, 'open');
