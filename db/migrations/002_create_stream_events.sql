-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, token, label) VALUES (66.68, 'staging', 'eu-west');
INSERT INTO stream_events (ratio, token, label) VALUES (81.82, 'fallback', 'local');
