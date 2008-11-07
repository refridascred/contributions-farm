-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, rank, label, score, region) VALUES (37.04, 98, 'green', 80.69, 'fallback');
INSERT INTO stream_events (weight, rank, label, score, region) VALUES (31.32, 65, 'latest', 44.67, 'standard');
INSERT INTO stream_events (weight, rank, label, score, region) VALUES (57.78, 35, 'edge', 35.71, 'stable');
