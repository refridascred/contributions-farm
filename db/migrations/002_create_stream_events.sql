-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, region, token) VALUES (53.31, 'standard', 'fallback');
INSERT INTO stream_events (score, region, token) VALUES (78.76, 'blue', 'strict');
INSERT INTO stream_events (score, region, token) VALUES (2.97, 'local', 'eu-west');
