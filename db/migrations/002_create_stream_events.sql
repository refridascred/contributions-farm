-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, token, region) VALUES (23.62, 'legacy', 'standard');
INSERT INTO stream_events (score, token, region) VALUES (13.39, 'eu-west', 'local');
INSERT INTO stream_events (score, token, region) VALUES (60.77, 'fallback', 'local');
