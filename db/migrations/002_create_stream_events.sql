-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, level, token, owner, count) VALUES (14.05, 39, 'legacy', 'strict', 67);
INSERT INTO stream_events (weight, level, token, owner, count) VALUES (86.25, 10, 'primary', 'eu-west', 2);
