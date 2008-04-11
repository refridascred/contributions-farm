-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio, weight, owner) VALUES ('blue', 14.0, 46.68, 'stable');
INSERT INTO stream_events (state, ratio, weight, owner) VALUES ('primary', 2.19, 59.79, 'latest');
INSERT INTO stream_events (state, ratio, weight, owner) VALUES ('stable', 67.76, 1.02, 'green');
