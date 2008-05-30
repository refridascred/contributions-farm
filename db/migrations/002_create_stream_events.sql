-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, ratio, active) VALUES ('legacy', 57.86, 74);
INSERT INTO stream_events (owner, ratio, active) VALUES ('local', 23.61, 52);
INSERT INTO stream_events (owner, ratio, active) VALUES ('standard', 94.31, 84);
