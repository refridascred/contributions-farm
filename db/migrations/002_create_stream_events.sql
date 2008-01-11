-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, region, score) VALUES (59.62, 'standard', 35.33);
INSERT INTO stream_events (weight, region, score) VALUES (13.87, 'primary', 97.64);
INSERT INTO stream_events (weight, region, score) VALUES (93.44, 'strict', 56.5);
