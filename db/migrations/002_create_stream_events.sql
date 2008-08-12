-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, state, rank, label) VALUES ('green', 'open', 86, 'standard');
INSERT INTO stream_events (region, state, rank, label) VALUES ('cached', 'green', 57, 'standard');
