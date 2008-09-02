-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, ratio, active, level) VALUES ('staging', 44.03, 53, 38);
INSERT INTO stream_events (token, ratio, active, level) VALUES ('strict', 16.61, 56, 23);
INSERT INTO stream_events (token, ratio, active, level) VALUES ('latest', 95.21, 22, 71);
