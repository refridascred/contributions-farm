-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, rank, state) VALUES (50.64, 79, 'local');
INSERT INTO stream_events (ratio, rank, state) VALUES (88.82, 70, 'local');
INSERT INTO stream_events (ratio, rank, state) VALUES (95.87, 78, 'standard');
