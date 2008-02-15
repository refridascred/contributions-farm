-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, score, ratio, owner) VALUES (65.14, 61.03, 32.78, 'eu-west');
INSERT INTO stream_events (weight, score, ratio, owner) VALUES (35.66, 80.06, 65.33, 'open');
INSERT INTO stream_events (weight, score, ratio, owner) VALUES (45.6, 3.95, 81.51, 'local');
