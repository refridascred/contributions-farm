-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, region, level, state, token) VALUES (14.36, 'standard', 42, 'eu-west', 'standard');
INSERT INTO stream_events (weight, region, level, state, token) VALUES (96.27, 'standard', 49, 'staging', 'eu-west');
