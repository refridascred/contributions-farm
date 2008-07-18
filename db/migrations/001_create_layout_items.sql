-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, score, label, owner, count) VALUES ('green', 28.08, 'fallback', 'green', 20);
INSERT INTO layout_items (token, score, label, owner, count) VALUES ('green', 46.13, 'legacy', 'staging', 52);
INSERT INTO layout_items (token, score, label, owner, count) VALUES ('green', 97.34, 'edge', 'open', 32);
