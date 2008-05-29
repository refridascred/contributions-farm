-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, weight, level, count, ratio) VALUES ('legacy', 77.78, 3, 85, 44.22);
INSERT INTO commits_records (owner, weight, level, count, ratio) VALUES ('edge', 7.87, 81, 52, 16.22);
INSERT INTO commits_records (owner, weight, level, count, ratio) VALUES ('cached', 44.01, 89, 85, 29.84);
