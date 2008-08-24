-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, ratio, owner, token, active) VALUES (51, 81.76, 'primary', 'open', 6);
INSERT INTO stream_events (rank, ratio, owner, token, active) VALUES (86, 1.18, 'primary', 'eu-west', 51);
