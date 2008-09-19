-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, score, ratio) VALUES ('standard', 47.96, 35.03);
INSERT INTO stream_events (token, score, ratio) VALUES ('local', 44.2, 44.23);
INSERT INTO stream_events (token, score, ratio) VALUES ('open', 14.08, 75.39);
