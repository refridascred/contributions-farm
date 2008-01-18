-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, ratio, token, rank) VALUES ('blue', 80.7, 'staging', 55);
INSERT INTO stream_events (state, ratio, token, rank) VALUES ('cached', 50.13, 'primary', 57);
