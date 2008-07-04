-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, active, score) VALUES (66, 89, 35.36);
INSERT INTO layout_items (level, active, score) VALUES (97, 60, 2.4);
INSERT INTO layout_items (level, active, score) VALUES (53, 74, 67.04);
