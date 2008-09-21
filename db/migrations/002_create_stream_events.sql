-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, score, label, level) VALUES (72, 5.05, 'latest', 38);
INSERT INTO stream_events (active, score, label, level) VALUES (3, 48.01, 'blue', 94);
INSERT INTO stream_events (active, score, label, level) VALUES (46, 66.78, 'blue', 25);
