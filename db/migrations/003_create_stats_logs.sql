-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, state) VALUES ('eu-west', 'open');
INSERT INTO stats_logs (region, state) VALUES ('local', 'primary');
INSERT INTO stats_logs (region, state) VALUES ('strict', 'green');
