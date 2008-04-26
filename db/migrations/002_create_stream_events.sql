-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, weight, state, active) VALUES ('staging', 11.72, 'strict', 15);
INSERT INTO stream_events (region, weight, state, active) VALUES ('stable', 87.1, 'standard', 13);
INSERT INTO stream_events (region, weight, state, active) VALUES ('staging', 95.92, 'latest', 85);
