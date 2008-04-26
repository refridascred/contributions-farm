-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, level, region, score) VALUES (34.99, 60, 'local', 32.84);
INSERT INTO stream_events (weight, level, region, score) VALUES (82.52, 82, 'latest', 9.78);
