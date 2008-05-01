-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (rank, label, score, region) VALUES (14, 'green', 70.14, 'blue');
INSERT INTO stream_events (rank, label, score, region) VALUES (67, 'open', 27.96, 'primary');
