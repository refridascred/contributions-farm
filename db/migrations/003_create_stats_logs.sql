-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, rank, level) VALUES ('local', 7, 10);
INSERT INTO stats_logs (owner, rank, level) VALUES ('green', 56, 79);
INSERT INTO stats_logs (owner, rank, level) VALUES ('legacy', 71, 2);
