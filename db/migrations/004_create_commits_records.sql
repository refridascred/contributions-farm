-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, rank, weight, count) VALUES (95, 85, 90.92, 21);
INSERT INTO commits_records (level, rank, weight, count) VALUES (19, 17, 87.6, 95);
INSERT INTO commits_records (level, rank, weight, count) VALUES (9, 18, 21.67, 75);
