-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, score, label) VALUES (30, 70.64, 'local');
INSERT INTO stream_events (active, score, label) VALUES (96, 7.23, 'primary');
INSERT INTO stream_events (active, score, label) VALUES (15, 74.49, 'standard');
