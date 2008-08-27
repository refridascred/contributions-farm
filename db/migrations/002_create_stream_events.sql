-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, level, ratio, token) VALUES ('green', 57, 33.25, 'eu-west');
INSERT INTO stream_events (state, level, ratio, token) VALUES ('staging', 63, 94.64, 'cached');
INSERT INTO stream_events (state, level, ratio, token) VALUES ('blue', 46, 24.22, 'edge');
