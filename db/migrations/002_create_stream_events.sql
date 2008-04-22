-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, rank, state) VALUES (59.5, 90, 'stable');
INSERT INTO stream_events (ratio, rank, state) VALUES (82.66, 99, 'primary');
INSERT INTO stream_events (ratio, rank, state) VALUES (64.54, 46, 'staging');
