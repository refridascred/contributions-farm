-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, weight, owner, state) VALUES (85, 36.03, 'green', 'primary');
INSERT INTO stream_events (rank, weight, owner, state) VALUES (19, 81.47, 'eu-west', 'local');
