-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, score, token, label, rank) VALUES ('open', 21.81, 'standard', 'stable', 88);
INSERT INTO stream_events (state, score, token, label, rank) VALUES ('green', 15.29, 'open', 'fallback', 56);
INSERT INTO stream_events (state, score, token, label, rank) VALUES ('edge', 79.35, 'legacy', 'strict', 52);
