-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, label, owner, rank) VALUES ('latest', 'local', 'strict', 83);
INSERT INTO stats_logs (region, label, owner, rank) VALUES ('local', 'stable', 'eu-west', 18);
