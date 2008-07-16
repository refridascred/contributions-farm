-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, count, active, weight, ratio) VALUES ('blue', 36, 67, 78.47, 35.83);
INSERT INTO stream_events (token, count, active, weight, ratio) VALUES ('cached', 29, 32, 16.79, 10.03);
