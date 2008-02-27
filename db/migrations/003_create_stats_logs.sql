-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, owner, weight) VALUES ('eu-west', 'latest', 17.68);
INSERT INTO stats_logs (label, owner, weight) VALUES ('strict', 'edge', 90.47);
INSERT INTO stats_logs (label, owner, weight) VALUES ('staging', 'stable', 49.58);
