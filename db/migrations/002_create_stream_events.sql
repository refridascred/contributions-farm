-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, weight, score, level) VALUES ('open', 24.46, 56.04, 76);
INSERT INTO stream_events (label, weight, score, level) VALUES ('fallback', 75.72, 68.55, 27);
INSERT INTO stream_events (label, weight, score, level) VALUES ('fallback', 42.26, 19.55, 87);
