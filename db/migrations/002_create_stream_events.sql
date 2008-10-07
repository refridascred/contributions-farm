-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, token, score) VALUES ('strict', 'primary', 89.14);
INSERT INTO stream_events (region, token, score) VALUES ('green', 'strict', 14.04);
