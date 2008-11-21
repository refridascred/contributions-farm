-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, state, weight, level) VALUES ('blue', 'blue', 90.79, 6);
INSERT INTO stream_events (label, state, weight, level) VALUES ('green', 'standard', 55.32, 97);
INSERT INTO stream_events (label, state, weight, level) VALUES ('latest', 'eu-west', 75.28, 82);
