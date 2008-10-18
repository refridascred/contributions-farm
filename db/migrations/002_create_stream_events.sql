-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, owner, score, state, rank) VALUES (34, 'primary', 89.96, 'strict', 38);
INSERT INTO stream_events (count, owner, score, state, rank) VALUES (26, 'fallback', 70.45, 'blue', 36);
INSERT INTO stream_events (count, owner, score, state, rank) VALUES (93, 'primary', 11.87, 'blue', 22);
