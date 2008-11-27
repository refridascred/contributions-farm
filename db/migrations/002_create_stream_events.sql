-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, weight, rank, ratio) VALUES (32.63, 4.53, 84, 3.73);
INSERT INTO stream_events (score, weight, rank, ratio) VALUES (93.5, 60.37, 62, 79.48);
