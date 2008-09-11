-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, region, score, count) VALUES ('stable', 'local', 90.65, 76);
INSERT INTO stream_events (state, region, score, count) VALUES ('strict', 'open', 81.32, 88);
INSERT INTO stream_events (state, region, score, count) VALUES ('edge', 'standard', 69.73, 10);
