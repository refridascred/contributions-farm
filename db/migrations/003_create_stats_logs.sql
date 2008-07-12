-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, label, ratio) VALUES ('edge', 'green', 39.28);
INSERT INTO stats_logs (owner, label, ratio) VALUES ('primary', 'local', 68.79);
INSERT INTO stats_logs (owner, label, ratio) VALUES ('primary', 'strict', 9.45);
