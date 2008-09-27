-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, weight, owner, region) VALUES (98, 40.65, 'primary', 'standard');
INSERT INTO commits_records (level, weight, owner, region) VALUES (51, 21.39, 'cached', 'stable');
INSERT INTO commits_records (level, weight, owner, region) VALUES (69, 88.24, 'staging', 'eu-west');
