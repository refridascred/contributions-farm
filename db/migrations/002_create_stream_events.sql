-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, score, weight, rank, region) VALUES (87, 72.37, 44.75, 23, 'eu-west');
INSERT INTO stream_events (level, score, weight, rank, region) VALUES (62, 17.52, 41.65, 50, 'fallback');
