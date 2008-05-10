-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, label, score, owner) VALUES (26.46, 'stable', 91.88, 'stable');
INSERT INTO stream_events (ratio, label, score, owner) VALUES (63.73, 'eu-west', 90.78, 'blue');
INSERT INTO stream_events (ratio, label, score, owner) VALUES (82.18, 'primary', 67.91, 'legacy');
