-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, weight, ratio, state) VALUES (68, 15.2, 59.93, 'open');
INSERT INTO stream_events (rank, weight, ratio, state) VALUES (22, 70.45, 73.97, 'blue');
INSERT INTO stream_events (rank, weight, ratio, state) VALUES (37, 89.06, 87.79, 'open');
