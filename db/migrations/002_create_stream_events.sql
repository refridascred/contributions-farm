-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, score, active) VALUES ('latest', 81.59, 79);
INSERT INTO stream_events (region, score, active) VALUES ('fallback', 8.25, 60);
INSERT INTO stream_events (region, score, active) VALUES ('fallback', 2.86, 74);
