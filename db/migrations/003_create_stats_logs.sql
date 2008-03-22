-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, ratio, owner) VALUES (28, 71.5, 'fallback');
INSERT INTO stats_logs (rank, ratio, owner) VALUES (14, 37.93, 'blue');
