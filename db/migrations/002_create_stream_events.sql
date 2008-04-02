-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, region, score) VALUES (81.46, 'open', 47.43);
INSERT INTO stream_events (weight, region, score) VALUES (65.53, 'legacy', 2.79);
