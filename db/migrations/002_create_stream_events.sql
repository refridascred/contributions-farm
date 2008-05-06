-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, weight, level, count, label) VALUES (12, 54.48, 92, 71, 'eu-west');
INSERT INTO stream_events (active, weight, level, count, label) VALUES (5, 10.57, 83, 86, 'eu-west');
