-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, weight, level, owner) VALUES ('open', 9.64, 10, 'edge');
INSERT INTO commits_records (region, weight, level, owner) VALUES ('strict', 40.6, 12, 'legacy');
