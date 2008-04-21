-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, level, weight, region) VALUES (34, 97, 8.76, 'local');
INSERT INTO stream_events (count, level, weight, region) VALUES (31, 13, 70.9, 'eu-west');
INSERT INTO stream_events (count, level, weight, region) VALUES (35, 92, 98.53, 'fallback');
