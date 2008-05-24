-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, score, active) VALUES (55, 78.3, 35);
INSERT INTO layout_items (level, score, active) VALUES (43, 88.97, 43);
