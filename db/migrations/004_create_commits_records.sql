-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, region, label, owner) VALUES (9.24, 'primary', 'legacy', 'latest');
INSERT INTO commits_records (ratio, region, label, owner) VALUES (76.6, 'strict', 'blue', 'latest');
INSERT INTO commits_records (ratio, region, label, owner) VALUES (57.77, 'edge', 'cached', 'legacy');
