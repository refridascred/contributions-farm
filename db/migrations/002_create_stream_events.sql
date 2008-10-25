-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, weight, score, ratio, owner) VALUES ('staging', 52.05, 62.85, 30.72, 'stable');
INSERT INTO stream_events (label, weight, score, ratio, owner) VALUES ('staging', 81.43, 38.72, 44.74, 'strict');
INSERT INTO stream_events (label, weight, score, ratio, owner) VALUES ('eu-west', 68.48, 11.51, 70.6, 'legacy');
