-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, region, score, state) VALUES (0, 'legacy', 4.72, 'standard');
INSERT INTO stream_events (rank, region, score, state) VALUES (3, 'legacy', 58.83, 'green');
INSERT INTO stream_events (rank, region, score, state) VALUES (37, 'legacy', 18.21, 'cached');
