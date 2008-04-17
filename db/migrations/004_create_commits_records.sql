-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, weight, level, owner, ratio) VALUES (9, 82.07, 97, 'standard', 73.8);
INSERT INTO commits_records (rank, weight, level, owner, ratio) VALUES (38, 37.03, 81, 'eu-west', 68.53);
