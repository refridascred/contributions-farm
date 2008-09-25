-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, token, score) VALUES (34.75, 'latest', 80.76);
INSERT INTO stream_events (weight, token, score) VALUES (43.03, 'latest', 0.56);
