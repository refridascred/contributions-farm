-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, label, weight, region, level) VALUES (27.34, 'primary', 4.1, 'local', 4);
INSERT INTO stream_events (ratio, label, weight, region, level) VALUES (32.93, 'open', 18.53, 'fallback', 96);
