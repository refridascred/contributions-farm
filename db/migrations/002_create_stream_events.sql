-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, state, region, score, token) VALUES (76.12, 'local', 'primary', 48.9, 'eu-west');
INSERT INTO stream_events (weight, state, region, score, token) VALUES (95.17, 'blue', 'latest', 94.04, 'eu-west');
INSERT INTO stream_events (weight, state, region, score, token) VALUES (13.39, 'stable', 'open', 29.22, 'edge');
