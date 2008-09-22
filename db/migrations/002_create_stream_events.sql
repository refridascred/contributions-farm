-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, score, weight, ratio) VALUES ('cached', 2.48, 15.29, 93.41);
INSERT INTO stream_events (token, score, weight, ratio) VALUES ('open', 58.57, 86.0, 62.48);
