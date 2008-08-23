-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, ratio) VALUES (67.3, 17.31);
INSERT INTO stream_events (score, ratio) VALUES (5.38, 71.17);
INSERT INTO stream_events (score, ratio) VALUES (22.73, 83.27);
