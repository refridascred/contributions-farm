-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, state, region, count) VALUES (97, 'standard', 'blue', 96);
INSERT INTO stream_events (rank, state, region, count) VALUES (72, 'eu-west', 'blue', 42);
INSERT INTO stream_events (rank, state, region, count) VALUES (17, 'open', 'green', 75);
