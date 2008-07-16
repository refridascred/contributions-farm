-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, level, owner) VALUES (17.94, 16, 'stable');
INSERT INTO stream_events (weight, level, owner) VALUES (1.91, 54, 'open');
INSERT INTO stream_events (weight, level, owner) VALUES (91.46, 69, 'eu-west');
