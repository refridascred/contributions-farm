-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, active, level, score, ratio) VALUES ('local', 22, 32, 95.87, 58.88);
INSERT INTO stream_events (label, active, level, score, ratio) VALUES ('legacy', 74, 81, 97.56, 98.51);
INSERT INTO stream_events (label, active, level, score, ratio) VALUES ('local', 0, 8, 43.67, 3.79);
