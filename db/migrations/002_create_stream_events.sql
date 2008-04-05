-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, rank, level, state) VALUES (68.86, 77, 75, 'eu-west');
INSERT INTO stream_events (ratio, rank, level, state) VALUES (95.68, 50, 2, 'stable');
