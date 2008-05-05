-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, owner, state, count) VALUES (97.89, 'eu-west', 'strict', 32);
INSERT INTO stream_events (weight, owner, state, count) VALUES (70.25, 'local', 'green', 35);
INSERT INTO stream_events (weight, owner, state, count) VALUES (33.95, 'eu-west', 'fallback', 65);
