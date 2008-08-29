-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, score, rank, ratio) VALUES ('fallback', 37.43, 10, 75.33);
INSERT INTO stream_events (region, score, rank, ratio) VALUES ('blue', 96.08, 72, 1.03);
INSERT INTO stream_events (region, score, rank, ratio) VALUES ('latest', 38.68, 4, 91.15);
