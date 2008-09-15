-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, label, token) VALUES (64.23, 'eu-west', 'primary');
INSERT INTO stream_events (ratio, label, token) VALUES (90.9, 'strict', 'staging');
INSERT INTO stream_events (ratio, label, token) VALUES (0.76, 'fallback', 'stable');
