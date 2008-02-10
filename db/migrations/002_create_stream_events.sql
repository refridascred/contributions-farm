-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, ratio, token) VALUES (50.67, 40.52, 'strict');
INSERT INTO stream_events (weight, ratio, token) VALUES (40.9, 83.44, 'primary');
INSERT INTO stream_events (weight, ratio, token) VALUES (38.83, 0.93, 'green');
