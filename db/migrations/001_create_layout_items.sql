-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, owner, score) VALUES (46, 'open', 77.67);
INSERT INTO layout_items (level, owner, score) VALUES (34, 'local', 77.59);
INSERT INTO layout_items (level, owner, score) VALUES (20, 'strict', 2.15);
