-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, active, level, rank, token) VALUES ('primary', 36, 40, 87, 'staging');
INSERT INTO stream_events (state, active, level, rank, token) VALUES ('green', 52, 4, 30, 'fallback');
