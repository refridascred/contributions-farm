-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, owner, ratio) VALUES (72.83, 'green', 8.57);
INSERT INTO stream_events (score, owner, ratio) VALUES (36.54, 'blue', 98.55);
