-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, weight, level, owner) VALUES ('staging', 18.68, 43, 'strict');
INSERT INTO stream_events (state, weight, level, owner) VALUES ('eu-west', 9.52, 14, 'latest');
INSERT INTO stream_events (state, weight, level, owner) VALUES ('latest', 35.25, 32, 'eu-west');
