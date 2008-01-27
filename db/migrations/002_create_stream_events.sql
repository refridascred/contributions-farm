-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, ratio, state, score, rank) VALUES (24, 56.13, 'open', 85.02, 0);
INSERT INTO stream_events (count, ratio, state, score, rank) VALUES (7, 44.62, 'eu-west', 47.06, 66);
INSERT INTO stream_events (count, ratio, state, score, rank) VALUES (66, 80.08, 'strict', 21.81, 59);
