-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, token, weight, ratio) VALUES (61, 'strict', 97.93, 58.61);
INSERT INTO stream_events (rank, token, weight, ratio) VALUES (78, 'eu-west', 61.22, 44.16);
