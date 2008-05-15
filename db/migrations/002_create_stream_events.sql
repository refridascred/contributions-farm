-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    token TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, weight, token, rank) VALUES (57, 50.94, 'staging', 54);
INSERT INTO stream_events (level, weight, token, rank) VALUES (60, 55.72, 'fallback', 89);
INSERT INTO stream_events (level, weight, token, rank) VALUES (45, 0.65, 'staging', 44);
