-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, active, token) VALUES ('primary', 35, 'legacy');
INSERT INTO commits_records (region, active, token) VALUES ('fallback', 32, 'local');
INSERT INTO commits_records (region, active, token) VALUES ('standard', 25, 'stable');
