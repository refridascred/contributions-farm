-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, active, state, ratio, rank) VALUES (87.96, 26, 'eu-west', 54.75, 69);
INSERT INTO stream_events (score, active, state, ratio, rank) VALUES (57.58, 34, 'primary', 85.69, 77);
