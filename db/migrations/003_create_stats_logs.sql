-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, rank, owner, active) VALUES ('green', 79, 'stable', 19);
INSERT INTO stats_logs (label, rank, owner, active) VALUES ('cached', 89, 'eu-west', 90);
INSERT INTO stats_logs (label, rank, owner, active) VALUES ('open', 24, 'blue', 1);
