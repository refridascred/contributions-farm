-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, region, active, rank) VALUES ('eu-west', 'eu-west', 39, 63);
INSERT INTO stats_logs (owner, region, active, rank) VALUES ('primary', 'blue', 34, 13);
INSERT INTO stats_logs (owner, region, active, rank) VALUES ('primary', 'open', 58, 56);
