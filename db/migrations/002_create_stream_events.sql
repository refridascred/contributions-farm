-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, weight) VALUES (7.81, 43.06);
INSERT INTO stream_events (score, weight) VALUES (49.36, 80.24);
INSERT INTO stream_events (score, weight) VALUES (98.89, 95.86);
