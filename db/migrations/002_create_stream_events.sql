-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, token, active, rank, owner) VALUES (22.83, 'standard', 51, 87, 'primary');
INSERT INTO stream_events (ratio, token, active, rank, owner) VALUES (10.25, 'staging', 32, 80, 'primary');
