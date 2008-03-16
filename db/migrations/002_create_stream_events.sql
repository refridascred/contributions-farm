-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, region, level) VALUES (34, 72.16, 'primary', 96);
INSERT INTO stream_events (count, weight, region, level) VALUES (91, 57.16, 'legacy', 62);
