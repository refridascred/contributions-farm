-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, weight, label, rank) VALUES (32.03, 92.93, 'stable', 0);
INSERT INTO stream_events (score, weight, label, rank) VALUES (19.23, 68.02, 'open', 6);
INSERT INTO stream_events (score, weight, label, rank) VALUES (31.55, 83.34, 'eu-west', 19);
