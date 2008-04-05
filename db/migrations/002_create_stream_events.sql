-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, ratio, score) VALUES ('eu-west', 81.68, 94.72);
INSERT INTO stream_events (owner, ratio, score) VALUES ('strict', 54.8, 51.15);
INSERT INTO stream_events (owner, ratio, score) VALUES ('standard', 8.25, 78.12);
