-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, level, region, token) VALUES (34.11, 27, 'eu-west', 'latest');
INSERT INTO stream_events (score, level, region, token) VALUES (88.26, 81, 'blue', 'staging');
