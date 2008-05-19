-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, weight, label, level, owner) VALUES ('local', 82.41, 'blue', 59, 'standard');
INSERT INTO commits_records (region, weight, label, level, owner) VALUES ('fallback', 75.04, 'blue', 38, 'primary');
INSERT INTO commits_records (region, weight, label, level, owner) VALUES ('blue', 13.6, 'cached', 11, 'cached');
