-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, weight, level) VALUES ('blue', 2.35, 40);
INSERT INTO stream_events (owner, weight, level) VALUES ('legacy', 65.21, 38);
INSERT INTO stream_events (owner, weight, level) VALUES ('latest', 97.14, 16);
