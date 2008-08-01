-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, owner, region, count) VALUES ('staging', 'cached', 'strict', 83);
INSERT INTO stats_logs (state, owner, region, count) VALUES ('legacy', 'eu-west', 'open', 8);
INSERT INTO stats_logs (state, owner, region, count) VALUES ('legacy', 'stable', 'blue', 95);
