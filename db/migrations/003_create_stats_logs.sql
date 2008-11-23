-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, rank, active, token, weight) VALUES ('strict', 75, 36, 'stable', 75.42);
INSERT INTO stats_logs (owner, rank, active, token, weight) VALUES ('eu-west', 14, 23, 'blue', 76.6);
INSERT INTO stats_logs (owner, rank, active, token, weight) VALUES ('open', 91, 0, 'stable', 24.52);
