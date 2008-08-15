-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, owner, score, count) VALUES (76.66, 'open', 72.46, 11);
INSERT INTO stream_events (weight, owner, score, count) VALUES (59.6, 'strict', 91.63, 62);
INSERT INTO stream_events (weight, owner, score, count) VALUES (76.88, 'eu-west', 56.42, 30);
