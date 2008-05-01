-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, rank, score, region) VALUES (71.67, 2, 8.1, 'latest');
INSERT INTO stream_events (weight, rank, score, region) VALUES (77.41, 9, 38.98, 'local');
INSERT INTO stream_events (weight, rank, score, region) VALUES (27.74, 11, 41.98, 'legacy');
