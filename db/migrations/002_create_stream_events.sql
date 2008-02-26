-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, label, region, weight) VALUES (75, 'latest', 'blue', 74.13);
INSERT INTO stream_events (count, label, region, weight) VALUES (16, 'cached', 'primary', 49.06);
INSERT INTO stream_events (count, label, region, weight) VALUES (70, 'fallback', 'strict', 70.56);
