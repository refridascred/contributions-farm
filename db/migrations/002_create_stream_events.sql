-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, token, weight, level) VALUES (75.8, 'primary', 59.96, 41);
INSERT INTO stream_events (score, token, weight, level) VALUES (7.11, 'edge', 87.68, 73);
