-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, active) VALUES (72.82, 34);
INSERT INTO stream_events (score, active) VALUES (36.31, 79);
INSERT INTO stream_events (score, active) VALUES (19.52, 86);
