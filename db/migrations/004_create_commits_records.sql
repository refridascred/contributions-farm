-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, owner, rank) VALUES (19, 'eu-west', 65);
INSERT INTO commits_records (level, owner, rank) VALUES (64, 'fallback', 97);
INSERT INTO commits_records (level, owner, rank) VALUES (96, 'staging', 26);
