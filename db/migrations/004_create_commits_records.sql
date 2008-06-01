-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, token, region, label, owner) VALUES (94, 'staging', 'strict', 'strict', 'open');
INSERT INTO commits_records (level, token, region, label, owner) VALUES (37, 'open', 'eu-west', 'open', 'legacy');
INSERT INTO commits_records (level, token, region, label, owner) VALUES (71, 'legacy', 'fallback', 'strict', 'cached');
