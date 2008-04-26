-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, token, score, level) VALUES ('legacy', 'legacy', 59.74, 37);
INSERT INTO stream_events (state, token, score, level) VALUES ('stable', 'standard', 14.48, 57);
INSERT INTO stream_events (state, token, score, level) VALUES ('strict', 'blue', 98.75, 42);
