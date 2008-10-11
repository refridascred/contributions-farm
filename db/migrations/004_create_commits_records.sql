-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, label, weight) VALUES ('stable', 'standard', 87.24);
INSERT INTO commits_records (owner, label, weight) VALUES ('blue', 'standard', 64.01);
INSERT INTO commits_records (owner, label, weight) VALUES ('open', 'strict', 71.48);
