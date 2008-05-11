-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, ratio, count, weight, label) VALUES ('cached', 32.67, 12, 85.39, 'legacy');
INSERT INTO stream_events (region, ratio, count, weight, label) VALUES ('fallback', 79.16, 3, 18.6, 'stable');
INSERT INTO stream_events (region, ratio, count, weight, label) VALUES ('staging', 26.24, 80, 71.55, 'cached');
