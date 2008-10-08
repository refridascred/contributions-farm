-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, owner, level) VALUES (0.24, 'green', 76);
INSERT INTO commits_records (weight, owner, level) VALUES (68.2, 'latest', 49);
INSERT INTO commits_records (weight, owner, level) VALUES (21.69, 'staging', 26);
