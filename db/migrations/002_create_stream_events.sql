-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, score, level) VALUES ('primary', 61.65, 40);
INSERT INTO stream_events (token, score, level) VALUES ('stable', 3.21, 81);
INSERT INTO stream_events (token, score, level) VALUES ('strict', 92.13, 88);
