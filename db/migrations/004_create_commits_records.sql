-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, level, owner, rank) VALUES ('cached', 35, 'primary', 31);
INSERT INTO commits_records (token, level, owner, rank) VALUES ('legacy', 63, 'primary', 68);
