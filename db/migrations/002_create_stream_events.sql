-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, weight, token, label) VALUES (63.77, 70.73, 'green', 'cached');
INSERT INTO stream_events (score, weight, token, label) VALUES (6.34, 98.91, 'legacy', 'edge');
INSERT INTO stream_events (score, weight, token, label) VALUES (45.97, 4.46, 'eu-west', 'primary');
