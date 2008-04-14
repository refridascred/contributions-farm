-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, label, score, level) VALUES ('staging', 'standard', 1.62, 59);
INSERT INTO stream_events (state, label, score, level) VALUES ('standard', 'cached', 73.99, 80);
