-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, score, ratio) VALUES (21, 63.9, 75.12);
INSERT INTO stream_events (active, score, ratio) VALUES (96, 79.85, 2.43);
INSERT INTO stream_events (active, score, ratio) VALUES (48, 69.41, 63.56);
