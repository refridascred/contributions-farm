-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, label, owner, count) VALUES ('staging', 'green', 'legacy', 55);
INSERT INTO stats_logs (token, label, owner, count) VALUES ('cached', 'legacy', 'strict', 70);
INSERT INTO stats_logs (token, label, owner, count) VALUES ('latest', 'legacy', 'stable', 16);
