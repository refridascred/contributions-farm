-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, ratio, active, state, level) VALUES ('eu-west', 26.44, 45, 'primary', 94);
INSERT INTO stream_events (token, ratio, active, state, level) VALUES ('latest', 12.72, 42, 'legacy', 71);
