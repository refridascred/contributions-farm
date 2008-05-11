-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, ratio, rank, weight) VALUES (91.8, 15.9, 68, 38.86);
INSERT INTO stream_events (score, ratio, rank, weight) VALUES (89.43, 59.55, 54, 74.74);
