-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, ratio, owner) VALUES ('green', 10.15, 'standard');
INSERT INTO commits_records (region, ratio, owner) VALUES ('legacy', 20.83, 'stable');
INSERT INTO commits_records (region, ratio, owner) VALUES ('open', 52.12, 'primary');
