-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, token, label, score, region) VALUES (80, 'fallback', 'local', 63.09, 'fallback');
INSERT INTO stream_events (rank, token, label, score, region) VALUES (48, 'latest', 'stable', 14.44, 'eu-west');
