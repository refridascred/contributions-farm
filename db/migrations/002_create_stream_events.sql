-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, score, state, ratio) VALUES ('eu-west', 18.4, 'latest', 39.86);
INSERT INTO stream_events (region, score, state, ratio) VALUES ('eu-west', 17.82, 'legacy', 0.68);
INSERT INTO stream_events (region, score, state, ratio) VALUES ('green', 22.86, 'standard', 24.8);
