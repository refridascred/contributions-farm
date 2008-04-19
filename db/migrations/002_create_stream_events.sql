-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, score, region, level) VALUES ('eu-west', 78.76, 'blue', 3);
INSERT INTO stream_events (state, score, region, level) VALUES ('green', 94.99, 'open', 35);
INSERT INTO stream_events (state, score, region, level) VALUES ('edge', 39.58, 'eu-west', 14);
