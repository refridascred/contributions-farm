-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, ratio, token) VALUES ('latest', 84.64, 'cached');
INSERT INTO stream_events (owner, ratio, token) VALUES ('local', 62.87, 'stable');
