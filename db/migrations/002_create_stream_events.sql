-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, owner, weight, level, region) VALUES (60, 'eu-west', 47.95, 29, 'strict');
INSERT INTO stream_events (rank, owner, weight, level, region) VALUES (60, 'latest', 21.17, 73, 'open');
INSERT INTO stream_events (rank, owner, weight, level, region) VALUES (2, 'green', 80.81, 48, 'fallback');
