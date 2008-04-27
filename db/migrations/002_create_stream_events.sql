-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, weight, region, token, owner) VALUES (4, 54.41, 'strict', 'legacy', 'green');
INSERT INTO stream_events (active, weight, region, token, owner) VALUES (31, 61.55, 'latest', 'blue', 'green');
