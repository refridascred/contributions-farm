-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, weight, owner, region) VALUES (75, 2.29, 'staging', 'standard');
INSERT INTO commits_records (level, weight, owner, region) VALUES (80, 34.51, 'green', 'legacy');
