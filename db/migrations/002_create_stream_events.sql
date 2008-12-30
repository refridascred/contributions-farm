-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, state, region, token) VALUES (15.8, 'local', 'green', 'staging');
INSERT INTO stream_events (weight, state, region, token) VALUES (0.8, 'standard', 'blue', 'edge');
INSERT INTO stream_events (weight, state, region, token) VALUES (56.72, 'edge', 'open', 'stable');
