-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (token, ratio, score) VALUES ('edge', 45.79, 8.43);
INSERT INTO stream_events (token, ratio, score) VALUES ('legacy', 82.35, 71.82);
