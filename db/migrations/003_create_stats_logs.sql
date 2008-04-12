-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, label, weight) VALUES ('primary', 'local', 41.79);
INSERT INTO stats_logs (owner, label, weight) VALUES ('stable', 'strict', 78.35);
INSERT INTO stats_logs (owner, label, weight) VALUES ('strict', 'edge', 45.96);
