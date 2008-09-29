-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, region, count, weight) VALUES ('cached', 'latest', 52, 78.53);
INSERT INTO stream_events (label, region, count, weight) VALUES ('stable', 'open', 90, 80.61);
INSERT INTO stream_events (label, region, count, weight) VALUES ('open', 'legacy', 75, 31.84);
