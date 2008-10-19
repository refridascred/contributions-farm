-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, weight) VALUES (49.49, 47.81);
INSERT INTO stream_events (score, weight) VALUES (63.47, 14.84);
INSERT INTO stream_events (score, weight) VALUES (34.85, 83.06);
