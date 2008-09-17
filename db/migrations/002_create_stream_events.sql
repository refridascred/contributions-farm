-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, region, level, token) VALUES ('latest', 'open', 23, 'strict');
INSERT INTO stream_events (owner, region, level, token) VALUES ('eu-west', 'latest', 35, 'strict');
