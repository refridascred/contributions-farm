-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, level, ratio) VALUES (12, 35, 13.89);
INSERT INTO stream_events (active, level, ratio) VALUES (51, 2, 30.03);
INSERT INTO stream_events (active, level, ratio) VALUES (82, 91, 88.4);
