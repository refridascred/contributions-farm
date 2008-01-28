-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight) VALUES ('edge', 33.7);
INSERT INTO stream_events (region, weight) VALUES ('green', 9.2);
INSERT INTO stream_events (region, weight) VALUES ('eu-west', 27.69);
