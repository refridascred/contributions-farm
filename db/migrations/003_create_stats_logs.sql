-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, owner, weight) VALUES ('stable', 'primary', 82.57);
INSERT INTO stats_logs (region, owner, weight) VALUES ('eu-west', 'latest', 68.87);
INSERT INTO stats_logs (region, owner, weight) VALUES ('staging', 'latest', 81.71);
