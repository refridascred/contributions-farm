-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (region, owner, weight) VALUES ('staging', 'cached', 89.93);
INSERT INTO stream_events (region, owner, weight) VALUES ('edge', 'standard', 48.1);
INSERT INTO stream_events (region, owner, weight) VALUES ('standard', 'open', 35.27);
