-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, score) VALUES (1, 91.49);
INSERT INTO stream_events (active, score) VALUES (72, 86.39);
INSERT INTO stream_events (active, score) VALUES (85, 66.54);
