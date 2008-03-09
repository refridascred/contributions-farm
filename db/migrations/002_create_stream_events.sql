-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, score, active, weight, level) VALUES ('eu-west', 70.44, 18, 5.63, 28);
INSERT INTO stream_events (label, score, active, weight, level) VALUES ('green', 62.29, 51, 76.73, 10);
INSERT INTO stream_events (label, score, active, weight, level) VALUES ('latest', 71.49, 29, 30.09, 56);
