-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, owner, state) VALUES ('fallback', 'eu-west', 'fallback');
INSERT INTO stats_logs (region, owner, state) VALUES ('latest', 'staging', 'staging');
INSERT INTO stats_logs (region, owner, state) VALUES ('open', 'primary', 'cached');
