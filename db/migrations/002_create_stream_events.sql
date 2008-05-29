-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, weight, region, ratio) VALUES (17, 98.35, 'stable', 4.44);
INSERT INTO stream_events (level, weight, region, ratio) VALUES (46, 57.68, 'standard', 96.93);
INSERT INTO stream_events (level, weight, region, ratio) VALUES (17, 33.22, 'stable', 2.32);
