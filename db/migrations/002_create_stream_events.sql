-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, token, state, weight, region) VALUES ('eu-west', 'legacy', 'standard', 43.39, 'edge');
