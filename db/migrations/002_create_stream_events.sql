-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, ratio, state) VALUES (68, 59.11, 'strict');
INSERT INTO stream_events (rank, ratio, state) VALUES (27, 13.12, 'eu-west');
INSERT INTO stream_events (rank, ratio, state) VALUES (2, 30.38, 'green');
