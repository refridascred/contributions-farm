-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, active, region, weight, level) VALUES ('legacy', 23, 'standard', 86.12, 10);
INSERT INTO commits_records (owner, active, region, weight, level) VALUES ('primary', 43, 'open', 38.41, 65);
INSERT INTO commits_records (owner, active, region, weight, level) VALUES ('eu-west', 14, 'local', 13.4, 71);
