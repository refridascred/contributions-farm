-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, ratio, weight) VALUES ('eu-west', 1.89, 97.55);
INSERT INTO commits_records (owner, ratio, weight) VALUES ('green', 39.69, 82.06);
