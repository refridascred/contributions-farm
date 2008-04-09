-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, rank, state, weight, level) VALUES ('standard', 77, 'green', 79.52, 52);
INSERT INTO stream_events (owner, rank, state, weight, level) VALUES ('cached', 7, 'strict', 80.97, 5);
