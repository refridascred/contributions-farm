-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, token, ratio) VALUES (75.54, 'staging', 28.64);
INSERT INTO stream_events (score, token, ratio) VALUES (81.28, 'primary', 85.03);
INSERT INTO stream_events (score, token, ratio) VALUES (3.35, 'open', 70.96);
