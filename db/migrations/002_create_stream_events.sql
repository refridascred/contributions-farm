-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, level, state, weight) VALUES (71, 76, 'staging', 37.64);
INSERT INTO stream_events (rank, level, state, weight) VALUES (1, 61, 'staging', 47.4);
INSERT INTO stream_events (rank, level, state, weight) VALUES (25, 37, 'legacy', 16.44);
