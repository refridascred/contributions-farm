-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, owner, weight, active) VALUES (59.59, 'latest', 78.19, 17);
INSERT INTO commits_records (score, owner, weight, active) VALUES (67.47, 'latest', 11.92, 28);
INSERT INTO commits_records (score, owner, weight, active) VALUES (68.07, 'primary', 83.48, 66);
