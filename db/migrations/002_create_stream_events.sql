-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, weight, state) VALUES ('latest', 23.69, 'staging');
INSERT INTO stream_events (token, weight, state) VALUES ('blue', 22.44, 'primary');
INSERT INTO stream_events (token, weight, state) VALUES ('fallback', 38.89, 'staging');
