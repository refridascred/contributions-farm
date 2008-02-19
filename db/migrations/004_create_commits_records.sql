-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, level, weight) VALUES ('blue', 27, 13.24);
INSERT INTO commits_records (region, level, weight) VALUES ('primary', 70, 0.44);
INSERT INTO commits_records (region, level, weight) VALUES ('stable', 97, 74.74);
