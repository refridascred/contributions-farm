-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, token, level, rank) VALUES (35.26, 'local', 87, 35);
INSERT INTO commits_records (weight, token, level, rank) VALUES (18.25, 'latest', 14, 33);
INSERT INTO commits_records (weight, token, level, rank) VALUES (46.95, 'green', 37, 14);
