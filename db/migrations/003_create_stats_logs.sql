-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, token, owner, label, rank) VALUES (68.69, 'edge', 'eu-west', 'local', 83);
INSERT INTO stats_logs (weight, token, owner, label, rank) VALUES (3.59, 'open', 'latest', 'eu-west', 23);
INSERT INTO stats_logs (weight, token, owner, label, rank) VALUES (0.06, 'latest', 'staging', 'blue', 13);
