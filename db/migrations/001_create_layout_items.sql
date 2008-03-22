-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, label, level, weight) VALUES (21.04, 'stable', 56, 69.3);
INSERT INTO layout_items (score, label, level, weight) VALUES (23.26, 'local', 80, 17.33);
INSERT INTO layout_items (score, label, level, weight) VALUES (98.58, 'latest', 55, 31.91);
