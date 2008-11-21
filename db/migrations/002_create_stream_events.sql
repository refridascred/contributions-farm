-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, token, region, weight) VALUES ('eu-west', 'cached', 'fallback', 31.16);
INSERT INTO stream_events (label, token, region, weight) VALUES ('blue', 'green', 'blue', 30.89);
