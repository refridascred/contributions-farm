-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (token, level, label, score) VALUES ('primary', 39, 'latest', 81.12);
INSERT INTO stream_events (token, level, label, score) VALUES ('fallback', 33, 'primary', 36.8);
INSERT INTO stream_events (token, level, label, score) VALUES ('latest', 38, 'standard', 51.1);
