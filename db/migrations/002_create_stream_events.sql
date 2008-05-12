-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, state, label, active) VALUES (46.77, 'latest', 'local', 87);
INSERT INTO stream_events (score, state, label, active) VALUES (51.86, 'legacy', 'legacy', 57);
INSERT INTO stream_events (score, state, label, active) VALUES (41.06, 'legacy', 'edge', 71);
