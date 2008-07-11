-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, region, ratio) VALUES (55, 'primary', 58.54);
INSERT INTO stream_events (count, region, ratio) VALUES (82, 'legacy', 16.17);
INSERT INTO stream_events (count, region, ratio) VALUES (20, 'staging', 59.83);
