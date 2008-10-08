-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, rank, weight) VALUES ('fallback', 52, 28.23);
INSERT INTO stream_events (region, rank, weight) VALUES ('legacy', 11, 12.43);
