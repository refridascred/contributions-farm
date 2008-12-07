-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, token, ratio, level) VALUES (16.24, 'edge', 3.92, 69);
INSERT INTO stream_events (score, token, ratio, level) VALUES (23.92, 'local', 13.03, 81);
INSERT INTO stream_events (score, token, ratio, level) VALUES (79.77, 'standard', 25.41, 68);
