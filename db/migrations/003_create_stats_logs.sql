-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, ratio, weight, state) VALUES ('local', 3.19, 53.95, 'open');
INSERT INTO stats_logs (owner, ratio, weight, state) VALUES ('staging', 62.2, 74.74, 'standard');
