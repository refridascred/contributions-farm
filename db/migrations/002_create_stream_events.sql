-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, region, state, score) VALUES ('strict', 'standard', 'latest', 'open', 93.35);
INSERT INTO stream_events (token, label, region, state, score) VALUES ('fallback', 'eu-west', 'primary', 'edge', 0.52);
INSERT INTO stream_events (token, label, region, state, score) VALUES ('local', 'cached', 'primary', 'primary', 82.49);
