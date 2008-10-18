-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, rank, region, weight) VALUES ('green', 99, 'stable', 0.92);
INSERT INTO stream_events (state, rank, region, weight) VALUES ('stable', 43, 'strict', 59.28);
INSERT INTO stream_events (state, rank, region, weight) VALUES ('green', 0, 'stable', 6.82);
