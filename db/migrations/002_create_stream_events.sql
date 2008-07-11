-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, rank, state, region) VALUES (69.24, 35, 'cached', 'legacy');
INSERT INTO stream_events (weight, rank, state, region) VALUES (74.12, 18, 'staging', 'strict');
INSERT INTO stream_events (weight, rank, state, region) VALUES (1.46, 87, 'fallback', 'blue');
