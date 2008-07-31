-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, rank, region, ratio, weight) VALUES (65, 35, 'cached', 80.91, 62.86);
INSERT INTO stream_events (count, rank, region, ratio, weight) VALUES (73, 69, 'staging', 49.46, 22.6);
INSERT INTO stream_events (count, rank, region, ratio, weight) VALUES (77, 33, 'local', 44.92, 36.42);
