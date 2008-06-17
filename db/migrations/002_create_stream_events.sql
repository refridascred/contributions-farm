-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, score, token, ratio, weight) VALUES (62, 70.27, 'standard', 40.24, 26.63);
INSERT INTO stream_events (count, score, token, ratio, weight) VALUES (78, 77.02, 'cached', 68.69, 5.78);
