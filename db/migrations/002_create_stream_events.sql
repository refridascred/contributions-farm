-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score, state) VALUES ('strict', 90.71, 'open');
INSERT INTO stream_events (label, score, state) VALUES ('eu-west', 98.77, 'fallback');
INSERT INTO stream_events (label, score, state) VALUES ('primary', 9.88, 'local');
