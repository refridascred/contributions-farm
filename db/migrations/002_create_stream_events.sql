-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, count, score, level) VALUES ('blue', 11, 98.28, 15);
INSERT INTO stream_events (token, count, score, level) VALUES ('primary', 19, 58.1, 30);
INSERT INTO stream_events (token, count, score, level) VALUES ('open', 67, 84.06, 54);
