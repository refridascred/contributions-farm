-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (rank, level, label, score, weight) VALUES (92, 74, 'local', 98.23, 50.44);
INSERT INTO stream_events (rank, level, label, score, weight) VALUES (5, 38, 'latest', 95.93, 50.38);
INSERT INTO stream_events (rank, level, label, score, weight) VALUES (97, 25, 'local', 58.87, 98.83);
