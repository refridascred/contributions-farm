-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, weight, owner) VALUES (62, 39.44, 'stable');
INSERT INTO commits_records (active, weight, owner) VALUES (47, 41.05, 'primary');
INSERT INTO commits_records (active, weight, owner) VALUES (98, 30.5, 'green');
