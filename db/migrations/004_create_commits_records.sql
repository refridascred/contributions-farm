-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (score, active, region, owner) VALUES (50.91, 4, 'green', 'green');
INSERT INTO commits_records (score, active, region, owner) VALUES (78.06, 76, 'primary', 'eu-west');
INSERT INTO commits_records (score, active, region, owner) VALUES (65.03, 43, 'cached', 'standard');
