-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, ratio, owner, level) VALUES ('open', 75.49, 'green', 47);
INSERT INTO commits_records (label, ratio, owner, level) VALUES ('open', 54.79, 'strict', 80);
INSERT INTO commits_records (label, ratio, owner, level) VALUES ('open', 57.0, 'green', 57);
