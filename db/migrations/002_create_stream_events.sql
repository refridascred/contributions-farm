-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, token, label) VALUES (13, 'primary', 'fallback');
INSERT INTO stream_events (count, token, label) VALUES (32, 'edge', 'green');
INSERT INTO stream_events (count, token, label) VALUES (76, 'standard', 'stable');
