-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, region, token, weight) VALUES (48, 'legacy', 'edge', 83.44);
INSERT INTO stream_events (active, region, token, weight) VALUES (68, 'latest', 'green', 78.85);
