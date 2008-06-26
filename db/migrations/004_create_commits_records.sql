-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, weight, region, owner, token) VALUES (6, 84.71, 'legacy', 'primary', 'open');
INSERT INTO commits_records (rank, weight, region, owner, token) VALUES (63, 22.15, 'strict', 'cached', 'standard');
