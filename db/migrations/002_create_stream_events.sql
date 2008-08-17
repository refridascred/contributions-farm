-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, level, owner) VALUES (12.73, 12, 'eu-west');
INSERT INTO stream_events (ratio, level, owner) VALUES (12.7, 83, 'green');
INSERT INTO stream_events (ratio, level, owner) VALUES (93.33, 30, 'open');
