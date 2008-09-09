-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, ratio, token, label) VALUES (77.54, 89.44, 'local', 'primary');
INSERT INTO stream_events (weight, ratio, token, label) VALUES (92.8, 22.11, 'fallback', 'standard');
