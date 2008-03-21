-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, owner, rank, state, level) VALUES (36.12, 'local', 65, 'edge', 79);
INSERT INTO stream_events (score, owner, rank, state, level) VALUES (82.55, 'latest', 65, 'green', 56);
