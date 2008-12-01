-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, owner, score) VALUES ('legacy', 'standard', 11.87);
INSERT INTO stats_logs (label, owner, score) VALUES ('legacy', 'eu-west', 40.85);
INSERT INTO stats_logs (label, owner, score) VALUES ('standard', 'legacy', 53.34);
