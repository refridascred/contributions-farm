-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, count, level, label) VALUES (91.37, 36, 4, 'eu-west');
INSERT INTO stream_events (ratio, count, level, label) VALUES (52.62, 18, 99, 'green');
