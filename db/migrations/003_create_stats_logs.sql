-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, state, owner, weight) VALUES ('legacy', 'strict', 'latest', 98.47);
INSERT INTO stats_logs (label, state, owner, weight) VALUES ('primary', 'standard', 'primary', 1.72);
INSERT INTO stats_logs (label, state, owner, weight) VALUES ('green', 'edge', 'eu-west', 62.28);
