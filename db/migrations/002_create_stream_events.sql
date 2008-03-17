-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, weight, state) VALUES ('primary', 86.74, 'edge');
INSERT INTO stream_events (token, weight, state) VALUES ('primary', 87.72, 'edge');
INSERT INTO stream_events (token, weight, state) VALUES ('blue', 64.04, 'cached');
