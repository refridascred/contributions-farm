-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, weight, level, region) VALUES (90, 65.57, 82, 'fallback');
INSERT INTO stream_events (count, weight, level, region) VALUES (7, 41.46, 38, 'cached');
