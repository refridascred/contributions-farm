-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, score, level, state, rank) VALUES ('standard', 73.6, 39, 'staging', 38);
INSERT INTO stream_events (label, score, level, state, rank) VALUES ('staging', 77.42, 30, 'strict', 47);
