-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, active, ratio) VALUES (57, 44, 97.69);
INSERT INTO stream_events (level, active, ratio) VALUES (56, 84, 1.4);
INSERT INTO stream_events (level, active, ratio) VALUES (12, 99, 70.11);
