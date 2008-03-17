-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, active, weight, count, ratio) VALUES ('local', 82, 20.92, 34, 87.54);
INSERT INTO stream_events (region, active, weight, count, ratio) VALUES ('fallback', 74, 39.05, 66, 9.39);
INSERT INTO stream_events (region, active, weight, count, ratio) VALUES ('standard', 99, 45.98, 44, 90.55);
