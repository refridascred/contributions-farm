-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, weight, score, ratio, token) VALUES ('primary', 80.69, 68.08, 20.47, 'open');
INSERT INTO stream_events (owner, weight, score, ratio, token) VALUES ('strict', 48.51, 6.23, 5.47, 'local');
