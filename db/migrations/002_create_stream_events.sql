-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (weight, score, token, level, state) VALUES (11.7, 12.13, 'legacy', 59, 'cached');
INSERT INTO stream_events (weight, score, token, level, state) VALUES (73.7, 13.32, 'stable', 11, 'eu-west');
INSERT INTO stream_events (weight, score, token, level, state) VALUES (51.23, 58.36, 'local', 36, 'eu-west');
