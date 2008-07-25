-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (score, rank, token, weight, label) VALUES (53.71, 86, 'eu-west', 23.81, 'stable');
INSERT INTO stream_events (score, rank, token, weight, label) VALUES (34.67, 25, 'staging', 24.13, 'legacy');
INSERT INTO stream_events (score, rank, token, weight, label) VALUES (17.78, 47, 'blue', 65.86, 'latest');
