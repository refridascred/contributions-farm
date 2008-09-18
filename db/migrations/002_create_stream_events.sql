-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, ratio, score) VALUES (83, 47.83, 47.2);
INSERT INTO stream_events (active, ratio, score) VALUES (61, 45.79, 11.8);
INSERT INTO stream_events (active, ratio, score) VALUES (11, 6.03, 67.44);
