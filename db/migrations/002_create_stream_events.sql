-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, token, level, label, owner) VALUES (48.33, 'primary', 29, 'green', 'eu-west');
INSERT INTO stream_events (ratio, token, level, label, owner) VALUES (97.27, 'green', 26, 'legacy', 'local');
