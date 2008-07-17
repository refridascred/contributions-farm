-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, label, owner, ratio) VALUES (50, 'cached', 'strict', 27.59);
INSERT INTO layout_items (level, label, owner, ratio) VALUES (40, 'legacy', 'green', 47.85);
INSERT INTO layout_items (level, label, owner, ratio) VALUES (31, 'legacy', 'standard', 98.39);
