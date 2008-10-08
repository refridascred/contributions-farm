-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, rank, weight, owner, region) VALUES ('legacy', 33, 68.22, 'standard', 'eu-west');
INSERT INTO commits_records (label, rank, weight, owner, region) VALUES ('green', 65, 57.86, 'primary', 'local');
INSERT INTO commits_records (label, rank, weight, owner, region) VALUES ('staging', 48, 3.47, 'legacy', 'edge');
