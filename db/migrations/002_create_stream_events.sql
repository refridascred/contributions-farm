-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, region, label, weight, owner) VALUES (21.81, 'edge', 'edge', 10.42, 'standard');
INSERT INTO stream_events (score, region, label, weight, owner) VALUES (93.23, 'stable', 'cached', 92.02, 'latest');
INSERT INTO stream_events (score, region, label, weight, owner) VALUES (60.82, 'strict', 'open', 32.63, 'edge');
