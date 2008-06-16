-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, token, weight, owner, level) VALUES (93.89, 'local', 53.63, 'open', 60);
INSERT INTO stream_events (score, token, weight, owner, level) VALUES (79.79, 'stable', 69.8, 'blue', 3);
INSERT INTO stream_events (score, token, weight, owner, level) VALUES (52.01, 'primary', 52.67, 'legacy', 85);
