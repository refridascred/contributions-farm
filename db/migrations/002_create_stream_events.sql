-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, weight, count) VALUES ('stable', 78.34, 10.92, 78);
INSERT INTO stream_events (region, ratio, weight, count) VALUES ('legacy', 76.97, 26.98, 11);
