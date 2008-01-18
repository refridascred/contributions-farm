-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, rank, ratio) VALUES ('eu-west', 85, 42.73);
INSERT INTO stream_events (owner, rank, ratio) VALUES ('eu-west', 10, 84.81);
INSERT INTO stream_events (owner, rank, ratio) VALUES ('blue', 48, 9.29);
