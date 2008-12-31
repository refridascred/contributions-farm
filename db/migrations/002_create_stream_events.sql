-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, ratio, label, count) VALUES (14.89, 'strict', 13.87, 'eu-west', 33);
INSERT INTO stream_events (weight, token, ratio, label, count) VALUES (64.13, 'fallback', 37.77, 'open', 45);
