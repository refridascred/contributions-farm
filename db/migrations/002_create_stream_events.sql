-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, weight, state, level) VALUES ('green', 37.5, 'fallback', 15);
INSERT INTO stream_events (owner, weight, state, level) VALUES ('latest', 3.93, 'primary', 33);
INSERT INTO stream_events (owner, weight, state, level) VALUES ('eu-west', 72.2, 'eu-west', 3);
