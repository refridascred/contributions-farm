-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, token, level, state) VALUES (77, 'eu-west', 13, 'open');
INSERT INTO stream_events (active, token, level, state) VALUES (90, 'eu-west', 51, 'fallback');
INSERT INTO stream_events (active, token, level, state) VALUES (1, 'primary', 32, 'stable');
