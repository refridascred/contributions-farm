-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, weight, label) VALUES (93.44, 17.58, 'stable');
INSERT INTO stream_events (ratio, weight, label) VALUES (79.41, 36.09, 'primary');
