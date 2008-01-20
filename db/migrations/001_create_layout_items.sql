-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, level, score) VALUES (90, 55, 79.27);
INSERT INTO layout_items (active, level, score) VALUES (68, 39, 28.7);
INSERT INTO layout_items (active, level, score) VALUES (17, 82, 97.62);
