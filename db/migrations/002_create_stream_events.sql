-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, score, ratio, region) VALUES ('primary', 77.25, 81.71, 'staging');
INSERT INTO stream_events (token, score, ratio, region) VALUES ('blue', 8.96, 95.92, 'blue');
