-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, score, owner, level, active) VALUES ('open', 48.25, 'eu-west', 8, 56);
INSERT INTO layout_items (token, score, owner, level, active) VALUES ('legacy', 49.65, 'legacy', 60, 21);
INSERT INTO layout_items (token, score, owner, level, active) VALUES ('standard', 64.28, 'standard', 4, 52);
