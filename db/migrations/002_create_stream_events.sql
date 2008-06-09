-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, weight, count) VALUES ('fallback', 78.92, 95);
INSERT INTO stream_events (state, weight, count) VALUES ('stable', 87.6, 72);
INSERT INTO stream_events (state, weight, count) VALUES ('latest', 95.16, 69);
