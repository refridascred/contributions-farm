-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, ratio, state) VALUES ('staging', 1.57, 'legacy');
INSERT INTO stream_events (owner, ratio, state) VALUES ('primary', 5.01, 'primary');
INSERT INTO stream_events (owner, ratio, state) VALUES ('green', 4.62, 'local');
