-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, score, label, region, rank) VALUES (84, 62.5, 'eu-west', 'local', 17);
INSERT INTO stream_events (count, score, label, region, rank) VALUES (16, 40.23, 'fallback', 'latest', 84);
