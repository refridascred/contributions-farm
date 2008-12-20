-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio, rank, score) VALUES ('strict', 8.11, 48, 85.5);
INSERT INTO stream_events (state, ratio, rank, score) VALUES ('fallback', 9.41, 0, 6.9);
INSERT INTO stream_events (state, ratio, rank, score) VALUES ('green', 67.98, 60, 37.96);
