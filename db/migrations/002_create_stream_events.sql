-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, ratio, weight, token, score) VALUES (82, 74.74, 55.12, 'edge', 10.74);
INSERT INTO stream_events (rank, ratio, weight, token, score) VALUES (87, 68.63, 51.5, 'latest', 3.72);
INSERT INTO stream_events (rank, ratio, weight, token, score) VALUES (76, 15.41, 1.8, 'eu-west', 97.96);
