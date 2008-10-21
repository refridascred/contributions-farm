-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, weight, state, score) VALUES ('stable', 70.71, 'blue', 79.64);
INSERT INTO stream_events (token, weight, state, score) VALUES ('primary', 22.83, 'legacy', 73.62);
