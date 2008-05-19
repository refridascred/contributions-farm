-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, rank, weight) VALUES ('eu-west', 0, 39.48);
INSERT INTO stream_events (owner, rank, weight) VALUES ('strict', 60, 40.71);
INSERT INTO stream_events (owner, rank, weight) VALUES ('latest', 36, 65.18);
