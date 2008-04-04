-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, active, rank) VALUES ('latest', 86, 17);
INSERT INTO stats_logs (owner, active, rank) VALUES ('edge', 51, 17);
INSERT INTO stats_logs (owner, active, rank) VALUES ('staging', 17, 10);
