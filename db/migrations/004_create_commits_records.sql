-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, count, weight, level) VALUES ('eu-west', 92, 86.22, 11);
INSERT INTO commits_records (owner, count, weight, level) VALUES ('eu-west', 29, 70.64, 90);
INSERT INTO commits_records (owner, count, weight, level) VALUES ('green', 6, 9.21, 5);
