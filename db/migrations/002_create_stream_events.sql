-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, weight, state, active, ratio) VALUES (84.43, 34.79, 'eu-west', 47, 68.28);
INSERT INTO stream_events (score, weight, state, active, ratio) VALUES (28.46, 1.15, 'blue', 2, 61.37);
