-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, token, count, level) VALUES ('cached', 'primary', 95, 33);
INSERT INTO commits_records (owner, token, count, level) VALUES ('local', 'stable', 26, 42);
INSERT INTO commits_records (owner, token, count, level) VALUES ('primary', 'staging', 24, 65);
