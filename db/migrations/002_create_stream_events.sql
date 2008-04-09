-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, token, label, weight, rank) VALUES ('strict', 'standard', 'fallback', 68.24, 26);
INSERT INTO stream_events (owner, token, label, weight, rank) VALUES ('primary', 'eu-west', 'stable', 83.54, 56);
INSERT INTO stream_events (owner, token, label, weight, rank) VALUES ('primary', 'primary', 'cached', 81.22, 78);
