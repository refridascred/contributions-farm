-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, label, region, weight) VALUES ('green', 'staging', 'legacy', 41.16);
INSERT INTO stream_events (token, label, region, weight) VALUES ('open', 'latest', 'legacy', 41.3);
