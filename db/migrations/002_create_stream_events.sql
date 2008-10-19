-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, weight, owner, token, ratio) VALUES (3, 82.01, 'primary', 'eu-west', 49.17);
INSERT INTO stream_events (rank, weight, owner, token, ratio) VALUES (43, 84.78, 'standard', 'edge', 71.93);
INSERT INTO stream_events (rank, weight, owner, token, ratio) VALUES (34, 64.52, 'blue', 'latest', 50.2);
