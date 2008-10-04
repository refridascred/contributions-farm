-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, ratio, token) VALUES (17.12, 65.54, 'edge');
INSERT INTO stream_events (weight, ratio, token) VALUES (80.27, 35.49, 'open');
INSERT INTO stream_events (weight, ratio, token) VALUES (21.63, 96.98, 'fallback');
