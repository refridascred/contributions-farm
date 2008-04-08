-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, rank, region, weight) VALUES (43, 13, 'edge', 72.89);
INSERT INTO stream_events (level, rank, region, weight) VALUES (21, 62, 'eu-west', 24.47);
INSERT INTO stream_events (level, rank, region, weight) VALUES (95, 15, 'primary', 70.41);
