-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, token, region) VALUES (68.92, 'strict', 'cached');
INSERT INTO stream_events (score, token, region) VALUES (17.93, 'local', 'stable');
INSERT INTO stream_events (score, token, region) VALUES (19.77, 'legacy', 'edge');
