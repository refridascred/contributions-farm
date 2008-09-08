-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, level, token, score, active) VALUES ('blue', 83, 'latest', 36.76, 72);
INSERT INTO stream_events (label, level, token, score, active) VALUES ('standard', 84, 'blue', 52.05, 6);
INSERT INTO stream_events (label, level, token, score, active) VALUES ('edge', 54, 'eu-west', 15.89, 51);
