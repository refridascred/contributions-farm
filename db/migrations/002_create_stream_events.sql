-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, token, weight, ratio, owner) VALUES (9, 'primary', 65.02, 36.9, 'legacy');
INSERT INTO stream_events (level, token, weight, ratio, owner) VALUES (40, 'local', 53.55, 38.84, 'open');
