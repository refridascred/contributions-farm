-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, ratio) VALUES (39.1, 'standard', 43.92);
INSERT INTO stream_events (weight, token, ratio) VALUES (55.94, 'eu-west', 8.99);
INSERT INTO stream_events (weight, token, ratio) VALUES (14.23, 'fallback', 89.19);
