-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, active, count, weight) VALUES ('eu-west', 96, 70, 11.69);
INSERT INTO stats_logs (owner, active, count, weight) VALUES ('blue', 96, 24, 89.13);
INSERT INTO stats_logs (owner, active, count, weight) VALUES ('strict', 71, 57, 11.77);
