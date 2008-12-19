-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, active, level, label, region) VALUES ('fallback', 80, 66, 'standard', 'open');
INSERT INTO stream_events (token, active, level, label, region) VALUES ('blue', 51, 61, 'open', 'strict');
