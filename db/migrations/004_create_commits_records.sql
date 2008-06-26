-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (score, active, region) VALUES (69.77, 29, 'standard');
INSERT INTO commits_records (score, active, region) VALUES (21.62, 45, 'primary');
INSERT INTO commits_records (score, active, region) VALUES (29.15, 85, 'local');
