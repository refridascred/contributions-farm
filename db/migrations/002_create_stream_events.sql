-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, owner, rank) VALUES (73.74, 'open', 73);
INSERT INTO stream_events (score, owner, rank) VALUES (88.75, 'stable', 92);
INSERT INTO stream_events (score, owner, rank) VALUES (81.97, 'green', 26);
