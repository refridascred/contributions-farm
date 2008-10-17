-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, score) VALUES (57, 66.82);
INSERT INTO stream_events (active, score) VALUES (30, 11.73);
INSERT INTO stream_events (active, score) VALUES (76, 16.81);
