-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, state, owner, ratio) VALUES (31, 'eu-west', 'stable', 12.82);
INSERT INTO stream_events (rank, state, owner, ratio) VALUES (22, 'blue', 'primary', 45.44);
INSERT INTO stream_events (rank, state, owner, ratio) VALUES (81, 'strict', 'stable', 21.89);
