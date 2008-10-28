-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, weight, rank, state) VALUES (69, 58.95, 23, 'open');
INSERT INTO stream_events (active, weight, rank, state) VALUES (81, 59.37, 41, 'local');
INSERT INTO stream_events (active, weight, rank, state) VALUES (65, 70.06, 59, 'latest');
