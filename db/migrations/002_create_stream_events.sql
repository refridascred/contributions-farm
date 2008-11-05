-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, rank, level, score) VALUES (51.01, 20, 14, 90.53);
INSERT INTO stream_events (ratio, rank, level, score) VALUES (59.57, 9, 75, 51.66);
INSERT INTO stream_events (ratio, rank, level, score) VALUES (87.12, 31, 80, 69.84);
