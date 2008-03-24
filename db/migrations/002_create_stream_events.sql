-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, weight, owner, region) VALUES (60.91, 8.01, 'open', 'strict');
INSERT INTO stream_events (score, weight, owner, region) VALUES (84.18, 53.18, 'eu-west', 'open');
INSERT INTO stream_events (score, weight, owner, region) VALUES (34.79, 57.5, 'green', 'cached');
