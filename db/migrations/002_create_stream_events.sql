-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, score, weight, owner) VALUES ('latest', 91.43, 42.52, 'standard');
INSERT INTO stream_events (label, score, weight, owner) VALUES ('edge', 42.47, 40.35, 'legacy');
