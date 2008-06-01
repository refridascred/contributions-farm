-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, level, region, score) VALUES (60.51, 86, 'green', 56.17);
INSERT INTO stream_events (weight, level, region, score) VALUES (35.84, 78, 'eu-west', 64.76);
INSERT INTO stream_events (weight, level, region, score) VALUES (38.43, 15, 'open', 46.4);
