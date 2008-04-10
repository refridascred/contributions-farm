-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, label, level, score) VALUES ('local', 'blue', 95, 6.59);
INSERT INTO commits_records (owner, label, level, score) VALUES ('standard', 'eu-west', 97, 10.79);
INSERT INTO commits_records (owner, label, level, score) VALUES ('staging', 'standard', 70, 55.86);
