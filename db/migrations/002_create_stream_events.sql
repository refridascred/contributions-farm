-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, weight, level, state, score) VALUES (69, 69.18, 2, 'latest', 95.66);
INSERT INTO stream_events (active, weight, level, state, score) VALUES (1, 21.43, 47, 'blue', 43.95);
INSERT INTO stream_events (active, weight, level, state, score) VALUES (43, 48.19, 12, 'green', 25.53);
