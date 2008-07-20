-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, rank) VALUES ('open', 18);
INSERT INTO stats_logs (owner, rank) VALUES ('blue', 10);
INSERT INTO stats_logs (owner, rank) VALUES ('cached', 4);
