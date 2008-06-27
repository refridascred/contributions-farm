-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, owner, region) VALUES (72.64, 'local', 'open');
INSERT INTO commits_records (weight, owner, region) VALUES (19.9, 'eu-west', 'primary');
