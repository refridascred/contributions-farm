-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, ratio, count, token) VALUES ('open', 53.25, 9, 'blue');
INSERT INTO stream_events (owner, ratio, count, token) VALUES ('legacy', 21.03, 84, 'edge');
INSERT INTO stream_events (owner, ratio, count, token) VALUES ('primary', 39.55, 31, 'edge');
