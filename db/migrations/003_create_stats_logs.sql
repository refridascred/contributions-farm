-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, owner, region, state) VALUES (14, 'legacy', 'legacy', 'primary');
INSERT INTO stats_logs (count, owner, region, state) VALUES (12, 'eu-west', 'standard', 'cached');
INSERT INTO stats_logs (count, owner, region, state) VALUES (88, 'blue', 'staging', 'blue');
