-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, active, score, weight) VALUES ('stable', 48, 2.26, 12.72);
INSERT INTO stream_events (region, active, score, weight) VALUES ('primary', 63, 13.17, 86.9);
