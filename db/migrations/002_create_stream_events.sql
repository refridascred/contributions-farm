-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio, rank) VALUES ('blue', 23.66, 64);
INSERT INTO stream_events (state, ratio, rank) VALUES ('latest', 30.38, 71);
INSERT INTO stream_events (state, ratio, rank) VALUES ('eu-west', 96.84, 16);
