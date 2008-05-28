-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, region, weight, label, count) VALUES ('stable', 'edge', 73.2, 'legacy', 64);
INSERT INTO stream_events (token, region, weight, label, count) VALUES ('legacy', 'cached', 25.94, 'legacy', 53);
