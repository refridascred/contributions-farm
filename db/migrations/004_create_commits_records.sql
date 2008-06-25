-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, level, token, weight) VALUES ('legacy', 19, 'open', 37.23);
INSERT INTO commits_records (label, level, token, weight) VALUES ('stable', 51, 'standard', 84.37);
