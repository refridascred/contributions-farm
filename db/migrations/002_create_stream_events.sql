-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, score, weight, active, ratio) VALUES ('primary', 77.54, 31.18, 62, 37.65);
INSERT INTO stream_events (state, score, weight, active, ratio) VALUES ('edge', 26.73, 21.43, 59, 20.89);
