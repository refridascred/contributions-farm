-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, owner, score, state) VALUES (98.77, 'latest', 88.0, 'local');
INSERT INTO stream_events (weight, owner, score, state) VALUES (25.31, 'staging', 43.59, 'edge');
INSERT INTO stream_events (weight, owner, score, state) VALUES (35.96, 'staging', 1.86, 'latest');
