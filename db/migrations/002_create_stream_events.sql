-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, ratio, label) VALUES (32, 16.13, 'eu-west');
INSERT INTO stream_events (level, ratio, label) VALUES (77, 56.92, 'open');
INSERT INTO stream_events (level, ratio, label) VALUES (24, 76.89, 'latest');
