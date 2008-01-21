-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, score, owner, level) VALUES ('stable', 86.08, 'blue', 94);
INSERT INTO layout_items (region, score, owner, level) VALUES ('strict', 69.39, 'legacy', 26);
