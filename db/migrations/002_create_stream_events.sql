-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, score, state) VALUES ('staging', 75.78, 'blue');
INSERT INTO stream_events (label, score, state) VALUES ('local', 86.64, 'open');
INSERT INTO stream_events (label, score, state) VALUES ('edge', 39.67, 'blue');
