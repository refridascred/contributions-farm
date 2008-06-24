-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, count, region) VALUES (74.94, 79, 'primary');
INSERT INTO stream_events (weight, count, region) VALUES (59.25, 99, 'legacy');
INSERT INTO stream_events (weight, count, region) VALUES (74.94, 2, 'stable');
