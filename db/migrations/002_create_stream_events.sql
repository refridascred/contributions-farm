-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, state, token, ratio) VALUES ('fallback', 'primary', 'eu-west', 92.51);
INSERT INTO stream_events (region, state, token, ratio) VALUES ('fallback', 'edge', 'eu-west', 80.84);
