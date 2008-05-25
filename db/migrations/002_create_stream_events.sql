-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, state, score, active) VALUES (22.06, 'legacy', 9.4, 88);
INSERT INTO stream_events (weight, state, score, active) VALUES (5.71, 'open', 40.83, 29);
INSERT INTO stream_events (weight, state, score, active) VALUES (14.99, 'cached', 9.98, 80);
