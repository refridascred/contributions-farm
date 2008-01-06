-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, token, ratio) VALUES (94, 'fallback', 4.57);
INSERT INTO stream_events (rank, token, ratio) VALUES (9, 'strict', 97.29);
INSERT INTO stream_events (rank, token, ratio) VALUES (34, 'local', 95.15);
