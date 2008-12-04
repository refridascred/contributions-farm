-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, level) VALUES (7.13, 'latest', 81);
INSERT INTO layout_items (score, owner, level) VALUES (8.4, 'latest', 66);
INSERT INTO layout_items (score, owner, level) VALUES (97.38, 'fallback', 22);
