-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, level, score, weight, active) VALUES ('primary', 28, 69.99, 86.03, 26);
INSERT INTO stream_events (region, level, score, weight, active) VALUES ('strict', 0, 46.32, 33.71, 64);
INSERT INTO stream_events (region, level, score, weight, active) VALUES ('cached', 6, 49.56, 92.44, 70);
