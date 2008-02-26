-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, label, score, token) VALUES (53.94, 'legacy', 25.9, 'local');
INSERT INTO stream_events (weight, label, score, token) VALUES (19.83, 'stable', 68.75, 'local');
INSERT INTO stream_events (weight, label, score, token) VALUES (69.06, 'primary', 5.25, 'primary');
