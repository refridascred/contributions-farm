-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, level, owner) VALUES ('legacy', 74, 'stable');
INSERT INTO commits_records (region, level, owner) VALUES ('local', 52, 'latest');
INSERT INTO commits_records (region, level, owner) VALUES ('primary', 79, 'primary');
