-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, active, score) VALUES (61, 58, 80.15);
INSERT INTO layout_items (level, active, score) VALUES (71, 97, 23.0);
INSERT INTO layout_items (level, active, score) VALUES (70, 55, 35.49);
