-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight) VALUES ('eu-west', 4.25);
INSERT INTO stream_events (region, weight) VALUES ('blue', 59.94);
INSERT INTO stream_events (region, weight) VALUES ('fallback', 50.81);
