-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, ratio, score, weight, active) VALUES ('latest', 21.75, 23.18, 68.9, 62);
INSERT INTO stream_events (state, ratio, score, weight, active) VALUES ('eu-west', 1.86, 18.48, 42.42, 41);
INSERT INTO stream_events (state, ratio, score, weight, active) VALUES ('edge', 72.3, 2.8, 70.28, 44);
