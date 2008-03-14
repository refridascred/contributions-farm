-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, token, rank, owner, count) VALUES ('eu-west', 'eu-west', 16, 'green', 29);
INSERT INTO stats_logs (label, token, rank, owner, count) VALUES ('legacy', 'primary', 36, 'stable', 11);
INSERT INTO stats_logs (label, token, rank, owner, count) VALUES ('green', 'fallback', 84, 'standard', 47);
