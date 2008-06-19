-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, state, level) VALUES ('eu-west', 'edge', 84);
INSERT INTO stats_logs (region, state, level) VALUES ('latest', 'fallback', 7);
INSERT INTO stats_logs (region, state, level) VALUES ('legacy', 'local', 58);
