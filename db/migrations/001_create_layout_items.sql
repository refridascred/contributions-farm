-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (score, active, label, level, weight) VALUES (54.89, 25, 'strict', 19, 92.34);
INSERT INTO layout_items (score, active, label, level, weight) VALUES (63.83, 95, 'primary', 99, 47.83);
