-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, owner, ratio) VALUES ('eu-west', 'edge', 34.85);
INSERT INTO stats_logs (label, owner, ratio) VALUES ('latest', 'strict', 89.41);
