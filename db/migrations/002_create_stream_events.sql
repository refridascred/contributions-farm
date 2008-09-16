-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, score, weight, token) VALUES ('legacy', 66.84, 48.81, 'standard');
INSERT INTO stream_events (label, score, weight, token) VALUES ('standard', 79.01, 53.02, 'fallback');
INSERT INTO stream_events (label, score, weight, token) VALUES ('standard', 68.62, 38.03, 'primary');
