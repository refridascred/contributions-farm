-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, owner, weight, label) VALUES (3, 'legacy', 78.38, 'strict');
INSERT INTO commits_records (level, owner, weight, label) VALUES (87, 'edge', 90.24, 'standard');
