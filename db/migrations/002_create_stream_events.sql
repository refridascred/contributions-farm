-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, region, weight, score) VALUES ('local', 'fallback', 54.46, 80.87);
INSERT INTO stream_events (token, region, weight, score) VALUES ('primary', 'local', 24.19, 22.17);
INSERT INTO stream_events (token, region, weight, score) VALUES ('staging', 'edge', 1.45, 94.58);
