-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, weight, label, level) VALUES ('staging', 94.17, 'fallback', 97);
INSERT INTO stream_events (token, weight, label, level) VALUES ('primary', 45.25, 'green', 78);
INSERT INTO stream_events (token, weight, label, level) VALUES ('local', 89.11, 'eu-west', 80);
