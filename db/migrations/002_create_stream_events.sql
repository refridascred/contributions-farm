-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, ratio, token, score) VALUES (0, 17.4, 'blue', 51.27);
INSERT INTO stream_events (active, ratio, token, score) VALUES (39, 88.31, 'open', 29.01);
INSERT INTO stream_events (active, ratio, token, score) VALUES (57, 98.77, 'local', 90.93);
