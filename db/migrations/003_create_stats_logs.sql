-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, ratio, region, rank) VALUES ('primary', 77.46, 'standard', 14);
INSERT INTO stats_logs (owner, ratio, region, rank) VALUES ('cached', 1.61, 'latest', 2);
INSERT INTO stats_logs (owner, ratio, region, rank) VALUES ('eu-west', 77.35, 'staging', 69);
