-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, token, state) VALUES (44.48, 'fallback', 'green');
INSERT INTO stream_events (ratio, token, state) VALUES (48.63, 'cached', 'standard');
INSERT INTO stream_events (ratio, token, state) VALUES (89.64, 'eu-west', 'standard');
