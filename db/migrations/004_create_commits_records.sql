-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, weight) VALUES ('blue', 15.82);
INSERT INTO commits_records (owner, weight) VALUES ('standard', 6.87);
INSERT INTO commits_records (owner, weight) VALUES ('primary', 58.81);
