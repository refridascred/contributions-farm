-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (rank, ratio, score, label) VALUES (32, 7.09, 33.05, 'staging');
INSERT INTO stream_events (rank, ratio, score, label) VALUES (92, 58.12, 7.35, 'green');
