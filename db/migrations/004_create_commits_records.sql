-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, weight, region) VALUES ('local', 68.31, 'eu-west');
INSERT INTO commits_records (owner, weight, region) VALUES ('primary', 61.89, 'eu-west');
INSERT INTO commits_records (owner, weight, region) VALUES ('green', 38.57, 'green');
