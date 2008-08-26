-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, region, count, score, label) VALUES ('cached', 'local', 7, 89.05, 'latest');
INSERT INTO stream_events (token, region, count, score, label) VALUES ('stable', 'local', 96, 86.33, 'green');
INSERT INTO stream_events (token, region, count, score, label) VALUES ('eu-west', 'green', 62, 50.72, 'green');
