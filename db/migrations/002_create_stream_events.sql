-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, region, weight, state) VALUES ('blue', 'local', 88.74, 'fallback');
INSERT INTO stream_events (token, region, weight, state) VALUES ('fallback', 'latest', 37.42, 'edge');
