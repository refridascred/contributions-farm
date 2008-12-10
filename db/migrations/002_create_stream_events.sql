-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, level, ratio, label) VALUES (2.3, 15, 2.52, 'open');
