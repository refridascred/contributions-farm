-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, region, weight, token, state) VALUES (69, 'fallback', 65.36, 'open', 'green');
INSERT INTO stream_events (active, region, weight, token, state) VALUES (75, 'legacy', 97.42, 'fallback', 'green');
