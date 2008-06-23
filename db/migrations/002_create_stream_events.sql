-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, score, count, label) VALUES (72, 69.33, 8, 'primary');
INSERT INTO stream_events (active, score, count, label) VALUES (50, 78.67, 91, 'eu-west');
INSERT INTO stream_events (active, score, count, label) VALUES (77, 93.23, 34, 'local');
