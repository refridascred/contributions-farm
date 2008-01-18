-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, count, score, token) VALUES ('eu-west', 85, 13.4, 'standard');
INSERT INTO stream_events (region, count, score, token) VALUES ('blue', 25, 24.59, 'eu-west');
INSERT INTO stream_events (region, count, score, token) VALUES ('stable', 87, 81.82, 'open');
