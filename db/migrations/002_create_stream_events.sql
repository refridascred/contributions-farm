-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, ratio, score) VALUES ('staging', 96.61, 95.16);
INSERT INTO stream_events (owner, ratio, score) VALUES ('eu-west', 35.79, 78.07);
INSERT INTO stream_events (owner, ratio, score) VALUES ('standard', 83.38, 34.9);
