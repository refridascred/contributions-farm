-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, rank, token) VALUES (89, 96, 'legacy');
INSERT INTO stream_events (count, rank, token) VALUES (86, 11, 'standard');
INSERT INTO stream_events (count, rank, token) VALUES (53, 36, 'fallback');
