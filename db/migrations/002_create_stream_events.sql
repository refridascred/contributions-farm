-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, token, level, count) VALUES (19, 'standard', 47, 84);
INSERT INTO stream_events (rank, token, level, count) VALUES (69, 'primary', 15, 36);
INSERT INTO stream_events (rank, token, level, count) VALUES (17, 'fallback', 74, 4);
