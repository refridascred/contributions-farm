-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, active, weight, ratio) VALUES ('eu-west', 50, 50.25, 52.19);
INSERT INTO commits_records (owner, active, weight, ratio) VALUES ('primary', 26, 22.38, 65.72);
INSERT INTO commits_records (owner, active, weight, ratio) VALUES ('stable', 53, 83.95, 66.51);
