-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, owner, weight, rank) VALUES ('strict', 'fallback', 31.56, 8);
INSERT INTO stream_events (token, owner, weight, rank) VALUES ('latest', 'open', 53.46, 87);
INSERT INTO stream_events (token, owner, weight, rank) VALUES ('blue', 'eu-west', 98.71, 4);
