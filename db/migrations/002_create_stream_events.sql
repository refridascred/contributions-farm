-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, state, score, token, weight) VALUES ('fallback', 'eu-west', 89.55, 'cached', 79.87);
INSERT INTO stream_events (region, state, score, token, weight) VALUES ('stable', 'strict', 21.03, 'eu-west', 54.46);
