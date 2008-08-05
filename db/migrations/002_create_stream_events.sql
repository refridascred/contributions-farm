-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, ratio, label) VALUES ('primary', 22.85, 'edge');
INSERT INTO stream_events (token, ratio, label) VALUES ('cached', 11.89, 'open');
INSERT INTO stream_events (token, ratio, label) VALUES ('fallback', 2.48, 'eu-west');
