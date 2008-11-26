-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, score, token) VALUES ('stable', 37.15, 'local');
INSERT INTO stream_events (region, score, token) VALUES ('green', 33.8, 'eu-west');
INSERT INTO stream_events (region, score, token) VALUES ('standard', 81.79, 'stable');
