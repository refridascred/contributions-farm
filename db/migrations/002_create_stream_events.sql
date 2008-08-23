-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, owner, score, state) VALUES ('cached', 'cached', 45.39, 'blue');
