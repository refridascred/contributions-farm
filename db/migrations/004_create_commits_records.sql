-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, level, weight, owner) VALUES ('local', 99, 62.41, 'blue');
INSERT INTO commits_records (region, level, weight, owner) VALUES ('eu-west', 80, 37.45, 'standard');
