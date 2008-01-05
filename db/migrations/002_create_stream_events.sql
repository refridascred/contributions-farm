-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, token, score, active, ratio) VALUES (7.61, 'primary', 45.3, 23, 55.12);
INSERT INTO stream_events (weight, token, score, active, ratio) VALUES (1.27, 'green', 54.95, 41, 23.73);
INSERT INTO stream_events (weight, token, score, active, ratio) VALUES (27.29, 'eu-west', 28.1, 4, 29.59);
