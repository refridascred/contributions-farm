-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, label, rank) VALUES ('staging', 'primary', 83);
INSERT INTO stats_logs (token, label, rank) VALUES ('strict', 'latest', 59);
INSERT INTO stats_logs (token, label, rank) VALUES ('legacy', 'legacy', 77);
