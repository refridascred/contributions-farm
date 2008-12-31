-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, ratio, label) VALUES ('open', 76.24, 'standard');
INSERT INTO stream_events (owner, ratio, label) VALUES ('primary', 23.02, 'strict');
INSERT INTO stream_events (owner, ratio, label) VALUES ('fallback', 60.67, 'blue');
