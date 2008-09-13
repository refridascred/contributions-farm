-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, weight, label, level, active) VALUES ('local', 49.01, 'local', 4, 92);
INSERT INTO stream_events (owner, weight, label, level, active) VALUES ('legacy', 34.88, 'local', 37, 85);
INSERT INTO stream_events (owner, weight, label, level, active) VALUES ('open', 39.66, 'blue', 86, 90);
