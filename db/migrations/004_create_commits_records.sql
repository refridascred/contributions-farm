-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, weight, label, owner) VALUES (95, 40.87, 'edge', 'eu-west');
INSERT INTO commits_records (count, weight, label, owner) VALUES (86, 67.51, 'stable', 'local');
