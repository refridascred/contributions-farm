-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, token, weight) VALUES (87.55, 'edge', 23.28);
INSERT INTO stream_events (score, token, weight) VALUES (64.68, 'primary', 4.73);
