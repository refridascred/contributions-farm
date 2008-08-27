-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, token, rank, ratio, active) VALUES (70, 'eu-west', 84, 44.01, 20);
INSERT INTO stream_events (level, token, rank, ratio, active) VALUES (54, 'green', 69, 6.68, 7);
INSERT INTO stream_events (level, token, rank, ratio, active) VALUES (72, 'eu-west', 17, 74.76, 10);
