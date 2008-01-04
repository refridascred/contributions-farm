-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, label, level, weight) VALUES ('blue', 'eu-west', 51, 37.31);
INSERT INTO stats_logs (owner, label, level, weight) VALUES ('strict', 'local', 36, 22.1);
INSERT INTO stats_logs (owner, label, level, weight) VALUES ('eu-west', 'stable', 89, 28.22);
