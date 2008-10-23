-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, state, ratio, rank) VALUES ('blue', 'fallback', 77.37, 73);
INSERT INTO stream_events (token, state, ratio, rank) VALUES ('local', 'primary', 58.26, 97);
