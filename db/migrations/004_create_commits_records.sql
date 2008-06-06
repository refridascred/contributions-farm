-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, level, active, region, owner) VALUES ('stable', 54, 73, 'open', 'eu-west');
INSERT INTO commits_records (label, level, active, region, owner) VALUES ('primary', 73, 23, 'standard', 'stable');
INSERT INTO commits_records (label, level, active, region, owner) VALUES ('legacy', 26, 57, 'legacy', 'green');
