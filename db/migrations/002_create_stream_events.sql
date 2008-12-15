-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, region, owner, weight, token) VALUES (1, 'primary', 'edge', 38.89, 'open');
INSERT INTO stream_events (level, region, owner, weight, token) VALUES (26, 'primary', 'edge', 29.49, 'fallback');
