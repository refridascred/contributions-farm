-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, label, score, level) VALUES ('cached', 'stable', 58.49, 13);
INSERT INTO stream_events (token, label, score, level) VALUES ('blue', 'eu-west', 18.87, 16);
INSERT INTO stream_events (token, label, score, level) VALUES ('blue', 'blue', 50.01, 47);
