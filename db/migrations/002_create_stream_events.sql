-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, score, active, ratio, weight) VALUES ('eu-west', 69.79, 86, 66.63, 50.27);
INSERT INTO stream_events (token, score, active, ratio, weight) VALUES ('staging', 92.51, 94, 35.33, 92.18);
