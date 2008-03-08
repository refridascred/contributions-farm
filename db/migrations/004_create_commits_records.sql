-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, rank, count, token, level) VALUES ('latest', 49, 64, 'fallback', 64);
INSERT INTO commits_records (region, rank, count, token, level) VALUES ('open', 68, 59, 'local', 94);
INSERT INTO commits_records (region, rank, count, token, level) VALUES ('latest', 10, 10, 'primary', 46);
