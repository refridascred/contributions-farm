-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, owner, score, active, label) VALUES (86, 'eu-west', 64.37, 45, 'stable');
INSERT INTO stream_events (rank, owner, score, active, label) VALUES (63, 'staging', 65.43, 44, 'green');
INSERT INTO stream_events (rank, owner, score, active, label) VALUES (42, 'eu-west', 43.73, 72, 'local');
