-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, token, ratio) VALUES (9.55, 'local', 87.11);
INSERT INTO stream_events (score, token, ratio) VALUES (96.84, 'latest', 40.8);
INSERT INTO stream_events (score, token, ratio) VALUES (26.87, 'local', 32.49);
