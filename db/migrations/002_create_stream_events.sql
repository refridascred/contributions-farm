-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, score, label, weight) VALUES ('strict', 4.11, 'legacy', 65.73);
INSERT INTO stream_events (region, score, label, weight) VALUES ('green', 38.34, 'local', 39.0);
