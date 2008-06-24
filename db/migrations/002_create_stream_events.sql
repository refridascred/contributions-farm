-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, level, rank, region) VALUES (14.0, 52, 17, 'edge');
INSERT INTO stream_events (weight, level, rank, region) VALUES (59.88, 52, 2, 'strict');
INSERT INTO stream_events (weight, level, rank, region) VALUES (20.1, 42, 73, 'eu-west');
