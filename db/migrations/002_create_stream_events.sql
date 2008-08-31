-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, level, token, ratio, owner) VALUES ('green', 27, 'blue', 8.1, 'legacy');
INSERT INTO stream_events (label, level, token, ratio, owner) VALUES ('cached', 95, 'fallback', 19.03, 'green');
