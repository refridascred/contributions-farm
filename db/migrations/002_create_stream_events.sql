-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, region, level, weight, active) VALUES (7.43, 'latest', 6, 49.92, 38);
INSERT INTO stream_events (ratio, region, level, weight, active) VALUES (4.09, 'eu-west', 84, 83.19, 35);
