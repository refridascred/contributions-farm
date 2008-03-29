-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, level, token) VALUES ('stable', 94, 'legacy');
INSERT INTO commits_records (region, level, token) VALUES ('latest', 5, 'edge');
INSERT INTO commits_records (region, level, token) VALUES ('primary', 66, 'open');
