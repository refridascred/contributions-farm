-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, owner, ratio, label, level) VALUES ('fallback', 'local', 60.66, 'standard', 44);
INSERT INTO stream_events (token, owner, ratio, label, level) VALUES ('open', 'fallback', 95.64, 'stable', 24);
