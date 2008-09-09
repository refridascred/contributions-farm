-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, region, weight, active, count) VALUES (11.94, 'blue', 71.22, 73, 99);
INSERT INTO stream_events (ratio, region, weight, active, count) VALUES (90.91, 'legacy', 39.74, 67, 38);
INSERT INTO stream_events (ratio, region, weight, active, count) VALUES (77.58, 'open', 34.06, 85, 15);
