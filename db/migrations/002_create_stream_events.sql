-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, ratio, rank, state) VALUES ('standard', 69.52, 49, 'open');
INSERT INTO stream_events (region, ratio, rank, state) VALUES ('cached', 20.06, 48, 'standard');
