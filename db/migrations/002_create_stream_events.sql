-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, weight, score) VALUES ('cached', 27.03, 51.37);
INSERT INTO stream_events (region, weight, score) VALUES ('stable', 19.7, 9.95);
INSERT INTO stream_events (region, weight, score) VALUES ('fallback', 71.74, 36.78);
