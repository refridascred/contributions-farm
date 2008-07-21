-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, weight, ratio, owner, token) VALUES (37, 0.57, 73.14, 'eu-west', 'legacy');
INSERT INTO stream_events (active, weight, ratio, owner, token) VALUES (8, 70.86, 51.41, 'primary', 'latest');
INSERT INTO stream_events (active, weight, ratio, owner, token) VALUES (76, 85.22, 38.54, 'edge', 'strict');
