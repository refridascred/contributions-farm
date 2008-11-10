-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, region, weight) VALUES (87, 'open', 85.78);
INSERT INTO stream_events (level, region, weight) VALUES (31, 'open', 2.61);
