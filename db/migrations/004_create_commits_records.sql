-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, level, weight) VALUES ('legacy', 60, 7.04);
INSERT INTO commits_records (owner, level, weight) VALUES ('stable', 3, 87.33);
INSERT INTO commits_records (owner, level, weight) VALUES ('cached', 29, 21.85);
