-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, count, token, ratio) VALUES (67.68, 39, 'primary', 97.28);
INSERT INTO stream_events (score, count, token, ratio) VALUES (79.2, 47, 'latest', 58.56);
INSERT INTO stream_events (score, count, token, ratio) VALUES (70.52, 50, 'standard', 80.29);
