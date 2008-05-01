-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, ratio, level, owner) VALUES ('latest', 57.79, 99, 'staging');
INSERT INTO commits_records (label, ratio, level, owner) VALUES ('standard', 26.1, 93, 'open');
