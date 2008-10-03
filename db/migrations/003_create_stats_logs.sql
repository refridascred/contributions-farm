-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, state, region, rank) VALUES (55, 'staging', 'local', 8);
INSERT INTO stats_logs (level, state, region, rank) VALUES (86, 'open', 'staging', 46);
INSERT INTO stats_logs (level, state, region, rank) VALUES (93, 'strict', 'strict', 20);
