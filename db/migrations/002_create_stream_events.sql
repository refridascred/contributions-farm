-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, weight, ratio, label, owner) VALUES (22.14, 68.61, 30.02, 'eu-west', 'cached');
INSERT INTO stream_events (score, weight, ratio, label, owner) VALUES (34.88, 11.21, 27.11, 'open', 'green');
