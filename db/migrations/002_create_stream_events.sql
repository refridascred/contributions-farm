-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    token TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, weight, token, level, region) VALUES (5, 5.16, 'stable', 96, 'blue');
INSERT INTO stream_events (rank, weight, token, level, region) VALUES (15, 35.41, 'fallback', 52, 'cached');
INSERT INTO stream_events (rank, weight, token, level, region) VALUES (66, 45.11, 'latest', 69, 'green');
