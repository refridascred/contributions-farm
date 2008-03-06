-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, state, label) VALUES (34, 'local', 'green');
INSERT INTO stream_events (rank, state, label) VALUES (58, 'open', 'eu-west');
INSERT INTO stream_events (rank, state, label) VALUES (66, 'latest', 'staging');
