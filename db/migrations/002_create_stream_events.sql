-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, level, score, ratio) VALUES ('edge', 50, 22.94, 62.85);
INSERT INTO stream_events (token, level, score, ratio) VALUES ('strict', 74, 80.92, 63.48);
INSERT INTO stream_events (token, level, score, ratio) VALUES ('edge', 75, 56.86, 12.39);
