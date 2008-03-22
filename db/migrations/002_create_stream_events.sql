-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, token, rank, weight, state) VALUES (4.7, 'stable', 22, 49.08, 'staging');
INSERT INTO stream_events (ratio, token, rank, weight, state) VALUES (86.0, 'eu-west', 2, 57.81, 'standard');
INSERT INTO stream_events (ratio, token, rank, weight, state) VALUES (5.18, 'stable', 56, 21.67, 'local');
