-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, rank, label) VALUES ('legacy', 57, 'stable');
INSERT INTO stats_logs (owner, rank, label) VALUES ('local', 65, 'blue');
INSERT INTO stats_logs (owner, rank, label) VALUES ('staging', 97, 'standard');
