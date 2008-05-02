-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, score, count, ratio) VALUES ('standard', 67.03, 42, 37.89);
INSERT INTO stream_events (region, score, count, ratio) VALUES ('strict', 50.4, 89, 69.45);
INSERT INTO stream_events (region, score, count, ratio) VALUES ('stable', 27.36, 80, 95.07);
