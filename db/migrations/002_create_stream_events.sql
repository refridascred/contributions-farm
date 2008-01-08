-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, region, score, weight) VALUES ('eu-west', 'latest', 14.82, 49.1);
INSERT INTO stream_events (state, region, score, weight) VALUES ('staging', 'green', 24.44, 55.6);
