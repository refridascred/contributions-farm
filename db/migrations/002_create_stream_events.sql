-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, active, score, label) VALUES ('strict', 68, 85.45, 'standard');
INSERT INTO stream_events (state, active, score, label) VALUES ('primary', 6, 76.09, 'edge');
INSERT INTO stream_events (state, active, score, label) VALUES ('strict', 25, 38.56, 'edge');
