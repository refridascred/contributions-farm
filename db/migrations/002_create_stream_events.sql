-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, count, label, score, rank) VALUES ('cached', 78, 'cached', 6.75, 27);
INSERT INTO stream_events (region, count, label, score, rank) VALUES ('local', 22, 'standard', 28.74, 8);
