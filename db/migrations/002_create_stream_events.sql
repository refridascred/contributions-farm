-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, label, ratio, token) VALUES (80, 'local', 50.31, 'eu-west');
INSERT INTO stream_events (level, label, ratio, token) VALUES (0, 'green', 19.71, 'cached');
