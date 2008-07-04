-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, count, score, ratio) VALUES ('fallback', 0, 65.38, 1.67);
INSERT INTO stream_events (token, count, score, ratio) VALUES ('open', 98, 62.82, 9.37);
INSERT INTO stream_events (token, count, score, ratio) VALUES ('primary', 20, 45.44, 32.41);
