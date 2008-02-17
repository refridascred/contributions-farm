-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, score, ratio, state, weight) VALUES ('staging', 65.73, 61.81, 'primary', 6.42);
INSERT INTO stream_events (label, score, ratio, state, weight) VALUES ('standard', 60.69, 41.91, 'strict', 79.66);
