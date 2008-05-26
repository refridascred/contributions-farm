-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, ratio, label, weight) VALUES ('fallback', 6.57, 'blue', 96.82);
INSERT INTO stream_events (token, ratio, label, weight) VALUES ('green', 58.25, 'eu-west', 39.18);
INSERT INTO stream_events (token, ratio, label, weight) VALUES ('cached', 21.57, 'fallback', 46.78);
