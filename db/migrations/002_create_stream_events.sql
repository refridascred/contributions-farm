-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, ratio, weight, label) VALUES ('primary', 87.93, 20.41, 'open');
INSERT INTO stream_events (owner, ratio, weight, label) VALUES ('green', 47.9, 94.45, 'stable');
