-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, state, ratio, owner, weight) VALUES (40, 'primary', 13.15, 'cached', 26.29);
INSERT INTO stream_events (level, state, ratio, owner, weight) VALUES (27, 'eu-west', 61.34, 'strict', 47.21);
INSERT INTO stream_events (level, state, ratio, owner, weight) VALUES (73, 'staging', 52.78, 'standard', 58.55);
