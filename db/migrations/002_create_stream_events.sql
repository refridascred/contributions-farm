-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, level, active, owner, region) VALUES (53.99, 88, 71, 'blue', 'fallback');
INSERT INTO stream_events (weight, level, active, owner, region) VALUES (50.89, 0, 58, 'edge', 'strict');
INSERT INTO stream_events (weight, level, active, owner, region) VALUES (5.14, 27, 34, 'staging', 'edge');
