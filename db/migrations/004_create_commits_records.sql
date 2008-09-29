-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, rank, level, ratio) VALUES ('local', 10, 23, 22.33);
INSERT INTO commits_records (region, rank, level, ratio) VALUES ('staging', 95, 38, 5.97);
INSERT INTO commits_records (region, rank, level, ratio) VALUES ('eu-west', 54, 9, 39.84);
