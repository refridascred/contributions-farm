-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, region, active, owner) VALUES (43.5, 'stable', 73, 'edge');
INSERT INTO commits_records (weight, region, active, owner) VALUES (44.03, 'local', 96, 'local');
INSERT INTO commits_records (weight, region, active, owner) VALUES (88.3, 'green', 43, 'standard');
