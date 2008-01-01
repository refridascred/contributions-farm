-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, label, level, active, rank) VALUES (9.77, 'staging', 6, 31, 74);
INSERT INTO stream_events (ratio, label, level, active, rank) VALUES (57.91, 'latest', 85, 94, 2);
INSERT INTO stream_events (ratio, label, level, active, rank) VALUES (64.29, 'primary', 7, 0, 51);
